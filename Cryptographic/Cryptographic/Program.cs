using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptographic;

namespace Cryptographic {
    class Program {
        static void Main(string[] args) {
            string Key;

            #region AES
            // AES 128
            Key = "SecretKey";

            string AES128Plane = "Hello World";
            string AES128Crypt = AESCrypto.EncryptAES(AES128Plane, Key, AESCrypto.AESCryptoList.AES128);
            string AES128Decrypt = AESCrypto.DecryptAES(AES128Crypt, Key, AESCrypto.AESCryptoList.AES128);

            // Extension Method
            AES128Crypt = AES128Plane.ToEncryptAES(Key, AESCrypto.AESCryptoList.AES128);
            AES128Decrypt = AES128Crypt.ToDecryptAES(Key, AESCrypto.AESCryptoList.AES128);


            // AES 256
            Key = "0123456789ABCDEF";

            string AES256Plane = "Hello World";
            string AES256Crypt = AESCrypto.EncryptAES(AES256Plane, Key, AESCrypto.AESCryptoList.AES256);
            string AES256Decrypt = AESCrypto.DecryptAES(AES256Crypt, Key, AESCrypto.AESCryptoList.AES256);

            // Extension Method
            AES256Crypt = AES256Plane.ToEncryptAES(Key, AESCrypto.AESCryptoList.AES256);
            AES256Decrypt = AES256Crypt.ToDecryptAES(Key, AESCrypto.AESCryptoList.AES256);
            #endregion

            #region DES
            // DES
            Key = "12345678";

            string DESPlane = "Hello World";
            string DESCrypt = DESCrypto.EncryptDES(DESPlane, Key);
            string DESDecrypt = DESCrypto.DecryptDES(DESCrypt, Key);

            // Extension Method
            DESCrypt = DESPlane.ToEncryptDES(Key);
            DESDecrypt = DESCrypt.ToDecryptDES(Key);

            #endregion

            #region RSA
            bool result;

            // Generate Private Key , Public Key
            string PrivateKey = RSACrypto.CreateRSAPrivateKey();
            string PublicKey = RSACrypto.CreateRSAPublicKey();

            // or file output
            result = RSACrypto.CreateRSAPrivateKey("C:\\RSA\\PrivateKey.txt");
            result = RSACrypto.CreateRSAPublicKey("C:\\RSA\\PublicKey.txt");

            string RSAPlane = "Hello World";

            string RSACrypt = RSACrypto.EncryptRSA(RSAPlane, PublicKey);
            string RSADecrypt = RSACrypto.DecryptRSA(RSAPlane, PrivateKey);

            // Extension Method
            RSAPlane = RSAPlane.toEncryptRSA(PublicKey);
            RSAPlane = RSAPlane.toDecryptRSA(PrivateKey);

            #endregion

            #region SEED
            Key = "0123456789ABCDEF";

            string SEEDPlane = "Hello World";

            string SEEDCrypt = SEEDCrypto.EncryptSEED(SEEDPlane, Key);
            string SEEDDecrypt = SEEDCrypto.DecryptSEED(SEEDCrypt, Key);

            // Extension Method
            SEEDCrypt = SEEDPlane.toEncryptSEED(Key);
            SEEDDecrypt = SEEDCrypt.toDecryptSEED(Key);
            #endregion

            #region Hash
            string HashPlane = "Hello World";

            string hashResult;

            hashResult = Hash.StringToHash(HashPlane, Hash.HashList.MD5);
            hashResult = Hash.StringToHash(HashPlane, Hash.HashList.SHA1);
            hashResult = Hash.StringToHash(HashPlane, Hash.HashList.SHA256);
            hashResult = Hash.StringToHash(HashPlane, Hash.HashList.SHA384);
            hashResult = Hash.StringToHash(HashPlane, Hash.HashList.SHA512);

            // Extension Method
            hashResult = HashPlane.ToHash(Hash.HashList.MD5);
            hashResult = HashPlane.ToHash(Hash.HashList.SHA1);
            hashResult = HashPlane.ToHash(Hash.HashList.SHA256);
            hashResult = HashPlane.ToHash(Hash.HashList.SHA384);
            hashResult = HashPlane.ToHash(Hash.HashList.SHA512);
            #endregion

            #region Utility
            string randPass = CryptoUtility.CreateRandomPassword(32);
            #endregion


        }
    }
}
