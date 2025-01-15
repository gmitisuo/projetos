using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Nota_final
{
    internal class Calculo
    {
        public string NotaFinal(string Nome,string Notas)
        {
            string[] _nota = Notas.TrimStart().Split(" ");
            double N1 = double.Parse(_nota[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(_nota[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(_nota[2], CultureInfo.InvariantCulture);
            double NF = (N1 / 2) + (N2 / 3) + (N3 / 5);
            if (NF > 6)
            {
                return Nome + " : " + NF.ToString("F2") + " Aprovado";
            }
            else
            {
                return Nome + " : " + NF.ToString("F2") + " Reprovado";
            }
        }
    }
}
