using System.ServiceModel;
using WarrierCards.Service.DataObjects.Account;

namespace WarrierCards.Service.Services.Security
{
    [ServiceContract]
    public interface ISecurityService
    {
        [OperationContract]
        int CheckLogin(LoginInfo loginInfo);

        [OperationContract]
        int Register(UserInfo userInfo);

        [OperationContract]
        bool SendPasswordResetEmail(string email);

        [OperationContract]
        bool ValidateChangePasswordToken(string token);

        [OperationContract]
        bool ChangePassword(string token, string newPassword);
    }
}
