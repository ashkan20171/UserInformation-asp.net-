using UserInformation.Core.RegisterVieweModels;
using UserInformation.Identity.MyUsers;

namespace UserInformation.Service.Interface
{
    public interface IRegisterService
    {
        //Is ExistUser
        bool IsExistUser(string user);

        //IsExistEmail
        bool IsExistEmail(string email);

        //AddUser
        int AddUser(Users user);

        Users SeeUserGetRegister(LoginViewModel login);

        bool UserIsActiveAccount(string activeCode);

        Users GetUserByEmail(string email);

        Users GetUserByActiveCode(string activeCode);

        void UpdateUser(Users user);
    }
}