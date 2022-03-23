using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD1_4
{
    internal class Conclusionist
    {
        public void GetConclusion(decimal kmi, TextBox inputForConclusion)
        {
            string conclusion = "";
            switch (kmi)
            {
                case <= 18.5m:
                    conclusion = "Asmuo yra nusilpes ir jo kuno svoris per mazas";
                    break;
                case > 18.5m and <= 25:
                    conclusion = "Idealus kuno mases indeksas";
                    break;
                case > 25 and <= 30:
                    conclusion = "Asmuo turi antsvori";
                    break;
                case > 30:
                    conclusion = "Asmuo yra nutukes";
                    break;
            }
            inputForConclusion.Text = conclusion;
        }
    }
}
