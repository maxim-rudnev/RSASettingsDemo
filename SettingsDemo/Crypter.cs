using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSASettingsDemo
{
    public static class Crypter
    {
        private static string key = "<RSAKeyValue><Modulus>u2Tc/r3+PCF/RJKzItIK0PvH6hI9Nm4JyVAceslyB/1ii1pHTzUycu+zEDPKGLwBf4zoxBDH9FoD5E3I+d0m3Ape+mzCcvexP4E5W6/kba4fWM5LFOCO+eSQmoR8nEsEI32QFOUjX5nsxVxahElxGRZVgdmQTLOaV626aShIRnE=</Modulus><Exponent>AQAB</Exponent><P>6ReHfDakGxwAevHkCFb/wQgh6JUdgOt/8MF9LCLepV/RQAaRn2mBC76Ghr6EVgKJt436FTTElBsV3rep9JHEmQ==</P><Q>zc+ZLtodrTYSCv/rqGZxrmnsY2UYOtQW0oezSQRuI7KwH5uPxsvE4RG0ELP1QYN2RG7VtPBdFYvuE2KPqv1fmQ==</Q><DP>0K+rMm9tP4Qzfd9hTIIvmnAgg641av3tXuysl75kXeVKX6tB51o7GfurT6n0q1i8WeU4GJJUyVDypKME+50iSQ==</DP><DQ>Ut5H+4lvcZLX6P3q0T+Ofn+/4rWN8AH9vn9NPRU/k7gbGl70oULi3wzVx/PtyJc6Q4utGNG/aTGShtOkrWCf4Q==</DQ><InverseQ>k4C24Kg3+dJEBj2VNz6Vrwjicq/idnWoL1+TzYliwSWs/Yai/oL5aaa1ZKCrVqqOJZdIz/yGcpQwrxvmbLD9Hg==</InverseQ><D>A2Rz+BGeRrOQNKss3oUWaIpHqCC3O83EqWtk70JyfnCzcL825MPGBhzO7Uy+txwU29yuwbk7DBz4DpFA7D25FxaP6CDbSRBI5Q0nJ608D7DJHXzxSVoxfe4rjIuQBA3fvwtTKYdjTegwyNX/4bevAEfrkfejp/EOFwvhvmfiJXE=</D></RSAKeyValue>";

        public static string Decrypt(string text)
        {
            byte[] decrContent = null;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            decrContent = rsa.Decrypt( Convert.FromBase64String(  text) , true);

            return _toString(decrContent);
        }

        private static string _toString(byte[] decrContent)
        {
            return Encoding.UTF8.GetString(decrContent);
        }

        private static byte[] _toByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string Encrypt(string text)
        {
            byte[] encContent = null;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            encContent = rsa.Encrypt(_toByte(text), true);

            return Convert.ToBase64String( encContent);
        }
    }
}
