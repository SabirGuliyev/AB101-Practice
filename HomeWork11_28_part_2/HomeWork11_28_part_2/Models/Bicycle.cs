using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_28_part_2.Models
{
    internal class Bicycle:Vehicle
    {
        private string _pedalKind;

        public string PedalKind
        {
            get { return _pedalKind; }
            set {
                if (value.Trim().Length>0)
                {
                    _pedalKind = value.Trim();
                }
                 
            }
        }

    }
}
