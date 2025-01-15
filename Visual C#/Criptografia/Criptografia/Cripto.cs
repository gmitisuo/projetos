using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    internal class Cripto
    {

        public string Crip(string caracter)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            keyValuePairs["a"] = "001";
            keyValuePairs["b"] = "002";
            keyValuePairs["c"] = "003";
            keyValuePairs["d"] = "004";
            keyValuePairs["e"] = "005";
            keyValuePairs["f"] = "006";
            keyValuePairs["g"] = "007";
            keyValuePairs["h"] = "008";
            keyValuePairs["i"] = "009";
            keyValuePairs["j"] = "010";
            keyValuePairs["k"] = "011";
            keyValuePairs["l"] = "012";
            keyValuePairs["m"] = "013";
            keyValuePairs["n"] = "014";
            keyValuePairs["o"] = "015";
            keyValuePairs["p"] = "016";
            keyValuePairs["q"] = "017";
            keyValuePairs["r"] = "018";
            keyValuePairs["s"] = "019";
            keyValuePairs["t"] = "020";
            keyValuePairs["u"] = "021";
            keyValuePairs["v"] = "022";
            keyValuePairs["w"] = "023";
            keyValuePairs["x"] = "024";
            keyValuePairs["y"] = "025";
            keyValuePairs["z"] = "026";


            return keyValuePairs[caracter];
        }
    }
}
