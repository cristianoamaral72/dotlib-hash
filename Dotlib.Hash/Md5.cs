using System.Security.Cryptography;
using System.Text;

namespace Dotlib.Hash
{
    public class Md5 : BaseHash
    {
        /// <summary>Valida se um string bate com um hash de MD5</summary>
        ///
        /// <param name="plainText">String em texto plano</param>
        /// <param name="hashText">String em MD5</param>
        new public static bool Validate(string plainText, string hashText) => hashText.Equals(Generate(plainText));

        /// <summary>Calcula o MD5 de uma string</summary>
        ///
        /// <param name="input">String a ser calculada</param>
        new public static string Generate(string input)
        {
            // Convertendo a String para array de bytes
            var hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));

            // StringBuilder para recompor a string
            var builder = new StringBuilder();

            // Formatando cada byte como uma String em hexadecimal
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
