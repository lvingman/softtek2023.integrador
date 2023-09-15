﻿using System.Security.Cryptography;
using System.Text;

namespace TechOil.Helper
{
    //TODO: Agregar mas capas de seguridad (SALT)
    public static class PasswordEncryptHelper
    {
        public static string EncryptPassword(string password, string mail = "")
        {
            var salt = CreateSalt(mail);
            string saltAndPwd = String.Concat(password, salt);
            var sha256 = SHA256.Create();
            var encoding = new ASCIIEncoding();
            var stream = Array.Empty<byte>();
            var sb = new StringBuilder();
            
            stream = sha256.ComputeHash(encoding.GetBytes(saltAndPwd));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            
            return sb.ToString();
        }

        private static string CreateSalt(string mail)
        {
            var salt = mail;
            byte[] saltBytes;
            string saltStr;
            saltBytes = ASCIIEncoding.ASCII.GetBytes(salt);
            long XORED = 0x00;

            foreach (byte b in saltBytes)
            {
                XORED = XORED ^ b;
            }

            Random rand = new Random(Convert.ToInt32(XORED));
            saltStr = rand.Next().ToString();
            saltStr += rand.Next().ToString();
            saltStr += rand.Next().ToString();
            saltStr += rand.Next().ToString();
            return saltStr;
        }
        
    }
}
