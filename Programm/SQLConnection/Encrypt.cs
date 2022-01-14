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
        /// <summary>
        /// Ändern das Passwort in Hash, aus String Datei von der Eingabe der Nutzer
        /// </summary>
        /// <param name="passwordString"></param>
        /// <returns></returns>
        public static string HashString(string passwordString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }
        /// <summary>
        /// Ändern das Passwort in Salt, aus String Datei von der Eingabe der Nutzer
        /// </summary>
        /// <param name="passwordString"></param>
        /// <returns></returns>
        public static string SaltString(string passwordString)
        {
            string salt = CreateSalt(10);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetSalt(passwordString, salt))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }
        /// <summary>
        /// Generieren ein Zufall Zahlen damit man es für Password Salting verwenden kann
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string CreateSalt(int size)
        {
            using (var generator = RandomNumberGenerator.Create())
            {
                var salt = new byte[size];
                generator.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }
        /// <summary>
        /// Hashing wird mit dieser Methode durchgeführt mit Namespace von Cryptography mit SHA256 Verfahren
        /// </summary>
        /// <param name="passwordString"></param>
        /// <returns></returns>
        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
        }
        /// <summary>
        /// Salting wird mit dieser Methode durchgeführt mit Namespace von Cryptography mit SHA256 Verfahren 
        /// </summary>
        /// <param name="passwordString"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static byte[] GetSalt (string passwordString, string salt)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString + salt));
        }
        
    }
}
