using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class EDevlet
    {
        private string TCNO = "12345678910";
        private string Name = "Kadir";
        private string LastName = "Ünver";

        public static bool kontrol = false;
        public EDevlet(string tc, string name, string lastname)
        {
            if(TCNO == tc && Name == name && LastName == lastname)
            {
                kontrol = true;
            }
        }

        public void IsTrue()
        {
            if (kontrol)
            {
                Console.WriteLine("kimlik bilgileri doğrudur satış yapılabilir");
            }
        }





    }
}
