using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects.Account;

namespace WarrierCards.Service.Services.Security
{
    public class SecurityService : ISecurityService
    {
        public int CheckLogin(LoginInfo loginInfo)
        {
            return 1;
        }

        public int Register(UserInfo userInfo)
        {
            // Register
            // Send welcome email to user
            return 0;
        }        

        public bool SendPasswordResetEmail(string email)
        {
            // Reset link format: /account/reset/token
            // token: create a token with the email and timestamp
            // Ecrypt token with a hash key, encode/decode only in service
            // Configure an expiry duration in config

            return true;
        }

        public bool ValidateChangePasswordToken(string token)
        {
            // Decode token, verify the timestamp is within expiry duration
            return true;
        }

        public bool ChangePassword(string token, string newPassword)
        {
            ValidateChangePasswordToken(token);
            // update passoword in database
            return true;
        }
    }
}
