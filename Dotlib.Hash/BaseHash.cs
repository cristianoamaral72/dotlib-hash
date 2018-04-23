using System;

namespace Dotlib.Hash
{
    public abstract class BaseHash
    {
        public static bool Validate(string plainText, string hashText) => throw new System.NotImplementedException();

        public static string Generate(string value) => throw new System.NotImplementedException();
    }
}
