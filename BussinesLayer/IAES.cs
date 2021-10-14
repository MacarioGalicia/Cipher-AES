using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public interface IAES
    {
        void SetKey(string key);
        string Cipher(string clearMessage);
        string Decipher(string cipherMessage);
        string GetKey();
    }
}
