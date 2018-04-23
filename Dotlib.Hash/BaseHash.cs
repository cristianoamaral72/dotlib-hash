using System;

namespace Dotlib.Hash
{
    public abstract class BaseHash
    {
        public static string Calculate(string value)
        {
            throw new System.NotImplementedException();
        }

        public static bool Validate(string plainText, string hashText) => plainText.Equals(hashText);
    }
}
