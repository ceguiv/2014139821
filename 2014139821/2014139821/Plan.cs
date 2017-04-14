using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class Plan
    {
        private TipoPlan plan;
        public int conta = 0;

        public Plan(string pln)
        {
            Planes = new TipoPlan(pln);
        }

        public TipoPlan Planes
        {
            get { return plan; }
            private set { plan = value; }
        }

        public void evaluacion(string tipPlan)
        {
            if (tipPlan == "Pre-pago")
            {
                Console.WriteLine("Se solicito una linea {0}, no es necesario evaluacion.\nFelicitaciones!!\n", tipPlan);
                conta++;
            }
            else
            {
                Console.Write("Se solicito una linea Post-pago, estara sujeta a evaluacion.\n");
            }
        }
    }
}
