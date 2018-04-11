using Signing.ECDSA;

namespace Signing
{
    public class ECKeyPair
    {
        /// <summary>
        /// Indicates wether the public key is compressed or not.
        /// </summary>
        public bool IsCompressed { get; private set; } = false;
        
        public byte[] PublicKey { get; private set; }
        public byte[] PrivateKey { get; private set; }

        public ECKeyPair(byte[] publicKey, byte[] privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public override string ToString()
        {
            return "Prv : " + PrivateKey.FormatKey() + "\nPub : " + PublicKey.FormatKey();
        }
    }
}