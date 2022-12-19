using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Oyun
    {

        public IKonsol konsol;

        public Oyun()
        {
            Console.WriteLine("Oyun basladi");
            konsol = new Hucum();
        }
        public void Ucbucaq()
        {
            konsol.UcbucaqBas();
        }
        public void Daire()
        {
            konsol.DaireBas();
        }
        public void Kvadrat()
        {
            konsol.KvadratBas();
        }
        public void X()
        {
            konsol.XBas();
        }
        public void TopItirildi()
        {
            Console.WriteLine("Top reqib terefinden ele kecirildi.Defansa kecilir");
            konsol = new Defans();
        }
        public void TopAlindi()
        {
            Console.WriteLine("Top Reqibden alindi.Hucuma kecirilir");
            konsol = new Hucum();
        }

    }
}
