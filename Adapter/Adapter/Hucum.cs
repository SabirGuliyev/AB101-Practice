using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Hucum : IKonsol
    {
        public void DaireBas()
        {
            Console.WriteLine("Yuxaridan Pas");
        }

        public void KvadratBas()
        {
            Console.WriteLine("Qapiya dogru top vurmaq");
        }

        public void UcbucaqBas()
        {
            Console.WriteLine("Ara pasi vermek");
        }

        public void XBas()
        {
            Console.WriteLine("Qisa pas vermek");
        }
    }
}
