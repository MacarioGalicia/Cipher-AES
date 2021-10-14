using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class AESCipher : IAES
    {
        private string _key = String.Empty;
        public string Cipher(string clearMessage)
        {
            byte[] encrypted;

            // Crear objeto AES y establecer propiedades
            using (Aes aes = Aes.Create())
            {
                aes.Key = Conversions.StringToByteArray(_key);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // Proceso de encryptado
                using (MemoryStream msEncrypt = new MemoryStream())
                {

                    // Creación de encriptor
                    ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, cryptoTransform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(clearMessage);
                        }

                        // Conactenar el array cifrado con el iv, para recuperarlo al descifrar
                        encrypted = concatenateIVAndCipher(aes.IV, msEncrypt.ToArray());
                    }
                }
            }

            // Codificando data cifrada a base64
            return Convert.ToBase64String(encrypted);
        }        

        public string Decipher(string cipherMessage)
        {
            string plaintext = null;

            // Decodificando data cifrada en base64
            byte[] cipherText = Convert.FromBase64String(cipherMessage);

            // Crear objeto AES y establecer propiedades
            using (Aes aes = Aes.Create())
            {
                aes.Key = Conversions.StringToByteArray(_key);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                byte[] iv = new byte[16];
                Array.Copy(cipherText, 0, iv, 0, 16);
                byte[] toDecrypt = new byte[cipherText.Length - 16];
                Array.Copy(cipherText, 16, toDecrypt, 0, cipherText.Length - 16);

                // Proceso de desifrado
                using (MemoryStream msDecrypt = new MemoryStream(toDecrypt))
                {
                    // Creación de desencriptor
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, iv);

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            // Se retorna texto descifrado
            return plaintext;

        }

        // Establecer llave
        public void SetKey(string key)
        {
            _key = key;
        }
        
        // Concatenar data cifrada con el iv utilizado al realizar el cifrado
        private byte[] concatenateIVAndCipher(byte[] iv, byte[] cipher)
        {
            byte[] buffer = new byte[iv.Length + cipher.Length];
            System.Buffer.BlockCopy(iv, 0, buffer, 0, iv.Length);
            System.Buffer.BlockCopy(cipher, 0, buffer, iv.Length, cipher.Length);
            return buffer;
        }

    }
}
