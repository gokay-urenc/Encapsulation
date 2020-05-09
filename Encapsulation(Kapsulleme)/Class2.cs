using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsulleme_
{
    class Class2
    {
        private string deger; // Field.
        public string GetDeger() // Okuma yapılacağı zaman.
        {
            return deger;
        }

        public void SetDeger(string parametre) // Atama yapılacağı zaman.
        {
            deger = parametre;
        }
    }
}