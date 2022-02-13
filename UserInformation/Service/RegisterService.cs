using Core.Security;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using UserInformation.Core.RegisterVieweModels;
using UserInformation.Generic;
using UserInformation.Identity.MyUsers;
using UserInformation.MyContext;
using UserInformation.Service.Interface;

namespace UserInformation.Service
{
    public class RegisterService : IRegisterService
    {
        private RegisterContext _Context;

        public RegisterService(RegisterContext context)
        {
            _Context = context;
        }

        #region Regisger &&  Login

        public bool IsExistUser(string user)
        {
            return _Context.Users.Any(u => u.UserName == user);
        }

        public bool IsExistEmail(string email)
        {
            return _Context.Users.Any(u => u.Email == email);
        }

        public int AddUser(Users user)
        {
            _Context.Users.Add(user);
            _Context.SaveChanges();
            return user.UserId;
        }

        public Users SeeUserGetRegister(LoginViewModel login)
        {
            login.Email = FixedEmail.FixedText(login.Email);
            login.Password = PasswordEncript.EncriptPassword(login.Password);
            return _Context.Users.SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);
        }

        public bool UserIsActiveAccount(string activeCode)
        {
            var user = _Context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
                return false;
            user.IsActive = true;
            user.ActiveCode = CreateUniqCode.buildCode();
            _Context.SaveChanges();
            return true;
        }

        public Users GetUserByEmail(string email)
        {
            return _Context.Users.SingleOrDefault(u => u.Email == email);
        }

        public Users GetUserByActiveCode(string activeCode)
        {
            return _Context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public void UpdateUser(Users user)
        {
            _Context.Users.Update(user);
            _Context.SaveChanges();
        }

        #endregion Regisger &&  Login
    }
}