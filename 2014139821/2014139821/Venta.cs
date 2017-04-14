using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class Venta
    {
        private Contrato contrato;
        private Evaluacion evaluacion;

        public Contrato Contract
        {
            get
            {
                return contrato;
            }
            set
            {
                contrato = value;
            }
        }

        public Evaluacion Evaluac
        {
            get
            {
                return evaluacion;
            }
            set
            {
                evaluacion = value;
            }
        }

        public Venta(string tipContrato, string plan)
        {
            contrato = new Contrato(tipContrato);
            evaluacion = new Evaluacion(plan);
        }


    }
}
