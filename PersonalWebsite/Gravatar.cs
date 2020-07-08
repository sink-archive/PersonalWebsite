using System;
using System.Security.Cryptography;
using System.Text;

namespace PersonalWebsite
{
    public static class Gravatar
    {
        /// Hashes an email with MD5.  Suitable for use with Gravatar profile
        /// image urls
        public static string HashEmailForGravatar(string email)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            var md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(email));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();  // Return the hexadecimal string.
        }

        public static string GetImageFromGravatar(string email, int size = 80, string fallback = "identicon", string rating = "g")
        {
            //  Compute the hash
            var hash = HashEmailForGravatar(email);

            //  Assemble the url and return
            return string.Format("http://www.gravatar.com/avatar/{0}?s={1}&d={2}&r={3}", hash, size, fallback, rating);
        }
    }
}
