using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DomashnayaKniga
{
    internal class Encryptor
    {
        const int saltSize = 8;
        public static string Hasher(string password, byte[] saltBytes)
        {
            if (saltBytes == null)
            {
                saltBytes = new byte[saltSize];
                var rng = RandomNumberGenerator.Create();
                rng.GetNonZeroBytes(saltBytes);
            }

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordWithSaltBytes = new byte[passwordBytes.Length + saltBytes.Length];
            for (int i = 0; i < passwordBytes.Length; i++) passwordWithSaltBytes[i] = passwordBytes[i];
            for (int i = 0; i < saltBytes.Length; i++) passwordWithSaltBytes[passwordBytes.Length + i] = saltBytes[i];

            HashAlgorithm hash = MD5.Create();
            byte[] hashBytes = hash.ComputeHash(passwordWithSaltBytes);
            byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];
            for (int i = 0; i < hashBytes.Length; i++) hashWithSaltBytes[i] = hashBytes[i];
            for (int i = 0; i < saltBytes.Length; i++) hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            return Convert.ToBase64String(hashWithSaltBytes);
        }

        public static byte[] Extract(string mixedHash)
        {
            byte[] hashWithSaltBytes = Convert.FromBase64String(mixedHash);
            byte[] saltBytes = new byte[saltSize];
            for (int i = 1; i <= saltBytes.Length; i++) saltBytes[saltBytes.Length - i] = hashWithSaltBytes[hashWithSaltBytes.Length - i];
            return saltBytes;
        }
    }
}
