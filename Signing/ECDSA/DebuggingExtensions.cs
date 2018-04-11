using System.Text;

namespace Signing.ECDSA
{
    public static class DebuggingExtensions
    {
        private static string PrintByteHexes(this byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
        
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
        
            return hex.ToString();
        }
        
        public static string FormatKey(this byte[] key)
        {
            return "[" + key.Length + ", " + key.PrintByteHexes() + "]";
        }
    }
}