using Org.BouncyCastle.Crypto.Parameters;
using Signing.ECDSA;

namespace Signing
{
    public class ECKeyPair
    {
        public ECPrivateKeyParameters PrivateKey { get; private set; }
        public ECPublicKeyParameters PublicKey { get; private set; }

        public ECKeyPair(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public override string ToString()
        {
            return "Prv : " + PrivateKey.D.ToByteArrayUnsigned().FormatKey() + "\nPub : " + PublicKey.Q.GetEncoded().FormatKey();
        }
    }
}