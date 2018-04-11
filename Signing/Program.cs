using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using Signing.ECDSA;

namespace Signing
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = KeyPairGenerator.Generate();
            Console.WriteLine(privateKey.ToString() + Environment.NewLine);
            
            byte[] message = new BigInteger("968236873715988614170569073515315707566766479517").ToByteArray();
            Signer.Sign(privateKey, message);
        }
    }

    public static class Signer
    {
        public static byte[] Sign(ECKeyPair keyPair, byte[] data)
        {
            ECPrivateKeyParameters priKey 
                = new ECPrivateKeyParameters("ECDSA", new BigInteger(keyPair.PrivateKey),  Parameters.DomainParams);
            
            ECDsaSigner ecdsaSigner = new ECDsaSigner();
            ecdsaSigner.Init(true, new ParametersWithRandom(priKey, Parameters.SecureRandom));
            
            BigInteger[] signature = ecdsaSigner.GenerateSignature(data);

            return new byte[0];
        }
    }
}