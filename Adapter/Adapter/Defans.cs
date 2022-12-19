using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Defans : IKonsol
    {
        public void DaireBas()
        {
            Console.WriteLine("Suruserek defans");
        }

        public void KvadratBas()
        {
            Console.WriteLine("Qoruyaraq defans");
        }

        public void UcbucaqBas()
        {
            Console.WriteLine("Qapicini cixardaraq defans");
        }

        public void XBas()
        {
            Console.WriteLine("Pressing tetbiq ederek defans");
        }
    }
}
