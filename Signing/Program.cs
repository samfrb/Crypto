using System;
using Org.BouncyCastle.Math;
using Signing.ECDSA;

namespace Signing
{
    class Program
    {
        static void Main(string[] args)
        {
            ECKeyPair keyPair = KeyPairGenerator.Generate();
            //Console.WriteLine(privateKey.ToString() + Environment.NewLine);
            
            // Fake data
            byte[] message = new BigInteger("968236873715988614170569073515315707566766479517").ToByteArray();
            
            ECSigner signer = new ECSigner();
            ECSignature signature = signer.Sign(keyPair, message);
            
            message = new BigInteger("9682368737159881417056907351531570756676647951").ToByteArray();
            ECVerifier verifier = new ECVerifier(keyPair);
            bool isGood = verifier.Verify(signature, message);
            
            Console.WriteLine(isGood);
        }
    }
}