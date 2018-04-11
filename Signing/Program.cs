using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Security;
using Signing.ECDSA;

namespace Signing
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = KeyPairGenerator.Generate();
            Console.WriteLine(privateKey.ToString() + Environment.NewLine);
            
        }
    }

    public class Signer
    {
        public byte[] Sign(ECKeyPair keyPair, byte[] data)
        {
            var signerAlgorithm = "SHA256withECDSA";

            ISigner signer = SignerUtilities.GetSigner(signerAlgorithm);
            
            ECDsaSigner ecdsaSigner = new ECDsaSigner();
            
            // todo
            /*signer.Init(true, );
            signer.BlockUpdate(data, 0, data.Length);
            byte[] signature = signer.GenerateSignature();*/

            return new byte[0];
        }
    }
}