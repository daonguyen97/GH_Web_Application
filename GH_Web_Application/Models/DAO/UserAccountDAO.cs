using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace GH_Web_Application.Models.DAO
{
    public class UserAccountDAO
    {
        public static string HashedPassword(string password)
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
        public static UserAccount GetAccount(int? id)
        {
            return new UserAccount();
        }

        public static UserAccount GetAccount(string email,string password)
        {
            string commandstr = "SELECT * FROM GH_USERACCOUNT " +
                                "WHERE EMAILADDRESS = :EMAIL AND PASSWORD = :PASSWORD";
            DataTable data = DbAccess.ExecuteQuery(commandstr,email,password);


            return new UserAccount(data.Rows[0]);
        }
        public static IEnumerable<UserAccount> GetAccounts()
        {
            List<UserAccount> accounts = new List<UserAccount>();
            string commandstr = "SELECT * FROM GH_USERACCOUNT";
            DataTable data = DbAccess.ExecuteQuery(commandstr);
            foreach (DataRow item in data.Rows)
            {
                UserAccount account = new UserAccount(item);
                accounts.Add(account);
            }
            return accounts;
        }

        public static void CreateAccount(UserAccount user)
        {
            string commandstr = "INSERT INTO GH_USERACCOUNT(USERID, NAME, PHONENUMBER, EMAILADDRESS, PASSWORD) " +
                                "VALUES(SEQ_USERID.NEXTVAL, :Name , :PhoneNumber , :EmailAdress , :Password )";
            DbAccess.ExecuteNonQuery(commandstr,user.Name,user.PhoneNumber,user.EmailAddress,user.Password);

        }        
    }
}
