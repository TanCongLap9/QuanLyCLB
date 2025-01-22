using System;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyCLB.Utils
{
    public static class PasswordUtils
    {
        public static string MaHoaTaiKhoan(string username, string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return string.Join(string.Empty, Array.ConvertAll(sha256.ComputeHash(
                    Encoding.Unicode.GetBytes(password + username + salt)
                ), b => b.ToString("x2")));
            }
        }

        public static string MaHoaMaBaoMatQuanLy(string maBaoMat)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return string.Join(string.Empty, Array.ConvertAll(sha256.ComputeHash(
                    Encoding.Unicode.GetBytes(maBaoMat)
                ), b => b.ToString("x2")));
            }
        }

        public static string GetRandomSalt()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] b = new byte[64];
                rng.GetBytes(b);
                return Convert.ToBase64String(b);
            }
        }
    }
}
