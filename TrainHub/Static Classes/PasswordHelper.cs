using System;
using System.Security.Cryptography;

namespace TrainHub
{
    public static class PasswordHelper
    {
        // Method to hash password using PBKDF2
        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Hash the password with the salt
            byte[] hash = HashPasswordWithSalt(password, salt);

            // Combine salt and hash for storage
            byte[] hashBytes = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);

            // Convert to base64 string for storage
            return Convert.ToBase64String(hashBytes);
        }

        // Method to verify password against stored hash
        public static bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                // Convert stored hash back to bytes
                byte[] hashBytes = Convert.FromBase64String(storedHash);

                // Extract salt (first 32 bytes)
                byte[] salt = new byte[32];
                Array.Copy(hashBytes, 0, salt, 0, 32);

                // Extract hash (remaining bytes)
                byte[] hash = new byte[hashBytes.Length - 32];
                Array.Copy(hashBytes, 32, hash, 0, hash.Length);

                // Hash the provided password with the extracted salt
                byte[] testHash = HashPasswordWithSalt(password, salt);

                // Compare hashes
                return SlowEquals(hash, testHash);
            }
            catch
            {
                return false;
            }
        }

        // Method to hash password with a given salt (used for verification)
        private static byte[] HashPasswordWithSalt(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32); // 32 bytes = 256 bits
            }
        }

        // Constant-time comparison to prevent timing attacks
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }
    }
}