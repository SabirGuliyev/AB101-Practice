using ClassWork11_25.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_25.Models
{

    internal class Web : Developer,ICSharp,IHtml
    {
        public byte CSHarpPercent { get ; set; }
        public byte HtmlPercent { get; set ; }
  

        public override void GetFullInfo()
        {
            Console.WriteLine(Name+" "+SalaryForHour+" "+IsFreelance);
        }
    }
}
