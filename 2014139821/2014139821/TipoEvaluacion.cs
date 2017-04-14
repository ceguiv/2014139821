using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class TipoEvaluacion
    {
        private string tipEval;

        public string TipoDeEval
        {
            get
            {
                return tipEval;
            }
            set
            {
                /*if (value == "Renovacion de contrato")
                    tipEval = value;
                else if (value == "Portabilidad")
                    tipEval = value;
                else if (value == "Linea nueva")
                    tipEval = value;*/
                tipEval = value;

            }
        }

        public void TipoEvaluar(string tEval)
        {
            TipoDeEval = tEval;
        }

    }
}
