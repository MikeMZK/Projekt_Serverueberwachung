using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encrypt
{
    public static class md5
    {
        public static byte[] encrypt(byte[] data)
        {
            string hash = "Hash";
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.ASCII.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    for (int i = 0; i < results.Length; i++)
                    {
                        if (results[i] == 255 || results[i] == 221)
                        {
                            results[i] = 0;
                        }
                    }

                    return results;
                }
            }
        }
    }
}