using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
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
        List<ShippingAddress> GetShippingAddressesByUserId(int userId);

        [OperationContract]
        bool SaveShippingAddress(ShippingAddress address);

        [OperationContract]
        bool SendPasswordResetEmail(string email);

        [OperationContract]
        bool ValidateChangePasswordToken(string token);

        [OperationContract]
        bool ChangePassword(string token, string newPassword);
    }
}
