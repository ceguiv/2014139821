using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class Contrato
    {
        private string tipoContrato;

        public string TipoContrato
        {
            get
            {
                return tipoContrato;
            }
            set
            {
                tipoContrato = value;
            }

        }

        public Contrato (string tC)
        {
            TipoContrato = tC;
        }
    }
}
