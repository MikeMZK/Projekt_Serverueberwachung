using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt
{
    public static class Rijndael
    {
        public static byte[] PassphraseBytes = Encoding.ASCII.GetBytes("ichbineinkrassespasswort");//funktioniert nicht wenn das Passwort verschieden ist
        public static byte[] SaltBytes = Encoding.ASCII.GetBytes("ichbinsalz");//mit dem String wird verschlüsselt

        public static byte[] Decrypt(byte[] input)
        {


            var pwdGen = new Rfc2898DeriveBytes(PassphraseBytes.ToString(), SaltBytes, 10000);
            using (var rijndaelManaged = new RijndaelManaged { BlockSize = 256 })
            {
                byte[] key = pwdGen.GetBytes(rijndaelManaged.KeySize / 8);
                byte[] iv = pwdGen.GetBytes(rijndaelManaged.BlockSize / 8);


                rijndaelManaged.Key = key;
                rijndaelManaged.IV = iv;

                byte[] decryptedBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, rijndaelManaged.CreateDecryptor(),
                        CryptoStreamMode.Write))
                    {

                        cs.Write(input, 0, input.Length);
                    }

                    decryptedBytes = ms.ToArray();
                }

                return decryptedBytes;
            }
        }

        public static byte[] Encrypt(string input)
        {
            return Encrypt(Encoding.UTF8.GetBytes(input));
        }

        public static byte[] Encrypt(byte[] input)
        {
            var pwdGen = new Rfc2898DeriveBytes(PassphraseBytes.ToString(), SaltBytes, 10000);
            using (var rijndaelManaged = new RijndaelManaged { BlockSize = 256 })
            {
                byte[] key = pwdGen.GetBytes(rijndaelManaged.KeySize / 8);
                byte[] iv = pwdGen.GetBytes(rijndaelManaged.BlockSize / 8);

                rijndaelManaged.Key = key;
                rijndaelManaged.IV = iv;

                byte[] encryptedBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, rijndaelManaged.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        cs.Write(input, 0, input.Length);
                    }

                    encryptedBytes = ms.ToArray();


                }

                return encryptedBytes;
            }
        }
    }
}
