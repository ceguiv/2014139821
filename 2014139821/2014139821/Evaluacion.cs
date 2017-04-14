using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class Evaluacion
    {
        private TipoEvaluacion tipEvaluacion;
        private TipoPlan tipPlan;
        public int cont = 0;
        public int cont2 = 0;


        public Evaluacion(string plane)
        {
            tipoEvaluacion = new TipoEvaluacion();
            tipPln = new TipoPlan(plane);
        }

        public TipoEvaluacion tipoEvaluacion
        {
            get { return tipEvaluacion; }
            private set { tipEvaluacion = value; }
        }

        public TipoPlan tipPln
        {
            get { return tipPlan; }
            private set { tipPlan = value; }
        }

        public void addEval(string tipEv)
        {
            if (tipEv == "Renovacion de contrato")
            {
                Console.WriteLine("Tipo de evaluacion seleccionado: {0}.\nSe realizaran las verificaciones correspondientes, por favor espere...", tipEv);
            }
            else if (tipEv == "Portabilidad")
            {
                Console.WriteLine("Tipo de evaluacion seleccionado: {0}.\nSe realizaran las verificaciones correspondientes, por favor espere...", tipEv);
            }
            else
                Console.WriteLine("Tipo de evaluacion seleccionado: {0}.\nSe realizaran las verificaciones correspondientes, por favor espere...", tipEv);
        }

        public void Evaluar(string estado, string tipEv)
        {
            if (estado == "Aprobado")
            {
                Console.WriteLine("Evaluacion satisfactoria.\n{0} : {1} \nSe procedera con la venta de la linea.\n", tipEv, estado);
                cont++;
            }
            else
            {
                Console.WriteLine("Evaluacion rechazada.\n{0} : {1} \nLo sentimos, no se puede concretar la adquisicion de la linea.\n", tipEv, estado);
                cont2++;
            }
        }
    }
}
