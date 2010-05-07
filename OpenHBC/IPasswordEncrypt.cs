using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace OpenHBC
{
    interface IPasswordEncrypt
    {
        string encryptPassword(string password);
    }

    class OpenhbcMd5: IPasswordEncrypt
    {
        
        public string encryptPassword(string password)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
    }

    
}
