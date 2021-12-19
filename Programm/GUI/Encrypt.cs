using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GUI
{
    class Encrypt
    {
        public static string HashString(string passwordString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }
        public static string SaltString(string passwordString)
        {
            string salt = CreateSalt(10);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetSalt(passwordString, salt))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }

        public static string CreateSalt(int size)
        {
            using (var generator = RandomNumberGenerator.Create())
            {
                var salt = new byte[size];
                generator.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }
        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
        }
        public static byte[] GetSalt (string passwordString, string salt)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString + salt));
        }
        
    }
}
