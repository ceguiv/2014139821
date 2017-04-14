using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _2014139821
{
    class Program
    {
        static void Main(string[] args)
        {
            int reporte, reporte1, reporte2;
            var tipEv = "Renovacion de contrato";
            var tipEv1 = "Portabilidad";
            var tipEv2 = "Linea nueva";
            var estado = "Aprobado";
            var estado2 = "Desaprobado";
            var tipPl = "Pre-pago";
            var tipPl1 = "Post-pago";

            Evaluacion eval;
            Venta vent = new Venta();

            //Primero se colocara una linea pre-pago, que no pasara por evaluacion.
            Console.WriteLine("------- Linea 1------");
            Plan plan = new Plan(tipPl);
            eval = new Evaluacion(tipPl);
            plan.evaluacion(tipPl);
            Thread.Sleep(4000);


            //Lineas Post-pago, sujetas a evaluacion.

            eval = new Evaluacion(tipPl1);

            Console.WriteLine("------- Linea 2------");
            plan.evaluacion(tipPl1);
            Thread.Sleep(2000);
            eval.addEval(tipEv);
            Thread.Sleep(4000);
            eval.Evaluar(estado, tipEv);
            Thread.Sleep(4000);

            Console.WriteLine("------- Linea 3------");
            plan.evaluacion(tipPl1);
            Thread.Sleep(2000);
            eval.addEval(tipEv1);
            Thread.Sleep(4000);
            eval.Evaluar(estado, tipEv1);
            Thread.Sleep(4000);

            Console.WriteLine("------- Linea 4------");
            plan.evaluacion(tipPl1);
            Thread.Sleep(2000);
            eval.addEval(tipEv2);
            Thread.Sleep(4000);
            eval.Evaluar(estado, tipEv2);
            Thread.Sleep(4000);

            Console.WriteLine("------- Linea 5------");
            plan.evaluacion(tipPl1);
            Thread.Sleep(2000);
            eval.addEval(tipEv2);
            Thread.Sleep(4000);
            eval.Evaluar(estado2, tipEv2);
            Thread.Sleep(4000);

            Console.WriteLine("------- Linea 6------");
            plan.evaluacion(tipPl1);
            Thread.Sleep(2000);
            eval.addEval(tipEv);
            Thread.Sleep(4000);
            eval.Evaluar(estado2, tipEv);
            Thread.Sleep(4000);

            //Reporte


            reporte = eval.cont;
            reporte1 = eval.cont2;
            reporte2 = plan.conta;

            Console.WriteLine("------- Reporte de lineas------");


            Console.WriteLine("Total de lineas Pre-pago aprobadas: " + reporte2);
            Console.WriteLine("Total de lineas Post-pago aprobadas: " + reporte);
            Console.WriteLine("Total de lineas Post-pago desaprobadas: " + reporte1);








            /*eval.tipoEvaluacion.TipoEvaluar(tipEv1);
            eval.tipoEvaluacion.TipoEvaluar(tipEv2);

            eval.tipoEvaluacion.TipoEvaluar(tipEv2);
            eval.tipoEvaluacion.TipoEvaluar(tipEv1);*/

        }
    }
}
