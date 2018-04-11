﻿using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Signing.ECDSA
{
    public static class KeyPairGenerator
    {
        /* Random source and curve */
        private static SecureRandom secureRandom = new SecureRandom();
        private static X9ECParameters curve = SecNamedCurves.GetByName("secp256k1");
        private static ECDomainParameters domain = new ECDomainParameters (curve.Curve, curve.G, curve.N, curve.H);
   
        public static ECKeyPair Generate()
        {
            ECKeyGenerationParameters keygenParams = new ECKeyGenerationParameters(domain, secureRandom);
        
            ECKeyPairGenerator generator = new ECKeyPairGenerator();
            generator.Init(keygenParams);
        
            AsymmetricCipherKeyPair keypair = generator.GenerateKeyPair();
        
            ECPrivateKeyParameters privParams = (ECPrivateKeyParameters)keypair.Private;
            ECPublicKeyParameters pubParams = (ECPublicKeyParameters)keypair.Public;
        
            ECKeyPair k = new ECKeyPair(pubParams.Q.GetEncoded(), privParams.D.ToByteArrayUnsigned());
        
            return k;
        }
    }
}