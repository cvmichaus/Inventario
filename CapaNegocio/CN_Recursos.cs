using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Recursos
    {
        //Encriptacion de texto es SHA256

        public static string ConvertirSHA256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            //Usar la referencia de "System.Security.Cryptography
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("X2"));
            }
            return Sb.ToString();
        }
    }
}
