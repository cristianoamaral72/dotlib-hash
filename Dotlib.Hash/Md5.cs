using System.Security.Cryptography;
using System.Text;

namespace Dotlib.Hash
{
    public class Md5 : BaseHash
    {
        /// <summary>Calcula o MD5 de uma string</summary>
        ///
        /// <param name="input">String a ser calculada</param>
        new public static string Generate(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convertendo a String para array de bytes
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // StringBuilder para recompor a string
            var builder = new StringBuilder();

            // Formatando cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
