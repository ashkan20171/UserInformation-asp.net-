using Core.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using UserInformation.Core.RegisterVieweModels;
using UserInformation.Generic;
using UserInformation.Identity.MyUsers;
using UserInformation.Service.Interface;

namespace UserInformation.Controllers
{
    public class AccountController : Controller
    {
        private IRegisterService _registerService;
        private IViewRenderService _viewRenderService;

        public AccountController(IRegisterService registerService, IViewRenderService viewRenderService)
        {
            _registerService = registerService;
            _viewRenderService = viewRenderService;
        }

        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_registerService.IsExistUser(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری موجود می باشد");
                return View(register);
            }
            if (_registerService.IsExistEmail(FixedEmail.FixedText(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد");
                return View(register);
            }
            //user insert
            Users user = new Users()
            {
                UserName = register.UserName,
                Email = FixedEmail.FixedText(register.Email),
                UserImage = "Default.jpg",
                ActiveCode = CreateUniqCode.buildCode(),
                IsActive = false,
                Password = PasswordEncript.EncriptPassword(register.Password),
                RegisterDate = DateTime.Now
            };
            _registerService.AddUser(user);

            #region SendeEmail

            string body = _viewRenderService.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعال سازی حساب کاربری", body);

            #endregion SendeEmail

            return View("SuccessRegister", user);
        }

        #endregion Register

        #region Login

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _registerService.SeeUserGetRegister(login);
            if (user != null)
            {
                if (user.IsActive)
                {
                    var claim = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };
                    var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);
                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد");
                }
            }

            ModelState.AddModelError("Email", "کاربری با این مشخصات وجود ندارد");
            return View(login);
        }

        #endregion Login

        #region ActiveCode

        public IActionResult ActiveCode(string id)
        {
            ViewBag.Issuccess = _registerService.UserIsActiveAccount(id);
            return View();
        }

        #endregion ActiveCode

        #region Logout

        [Route("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login");
        }

        #endregion Logout

        #region ForgetPassword

        [Route("ForgetPassword")]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [Route("ForgetPassword")]
        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordViewModel forget)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            string email = FixedEmail.FixedText(forget.Email);
            var user = _registerService.GetUserByEmail(email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "ایمیل شما وجود ندارد");
                return View(forget);
            }

            #region SendeEmail

            string body = _viewRenderService.RenderToStringAsync("_ForgetPassword", user);
            SendEmail.Send(user.Email, "بازیابی کلمه عبور", body);

            #endregion SendeEmail

            ViewBag.IsSuccess = true;
            return View();
        }

        #endregion ForgetPassword

        #region ResetPassword

        [HttpGet]
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {
                ActiveCode = id
            });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _registerService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
                return NotFound();

            string hashPassword = PasswordEncript.EncriptPassword(reset.Password);
            user.Password = hashPassword;
            _registerService.UpdateUser(user);
            ViewBag.IsSuccess = true;
            return View();
        }

        #endregion ResetPassword
    }
}