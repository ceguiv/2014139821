using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139821
{
    public class TipoPlan
    {
        private string tipPlan;

        public string TipoDePlan
        {
            get
            {
                return tipPlan;
            }
            set
            {
                /*if (value == "post-pago")
                    tipPlan = value;
                else if (value == "pre-pago")
                    tipPlan = value;                   */
                tipPlan = value;
            }
        }

        public TipoPlan(string tPlan)
        {
            TipoDePlan = tPlan;
        }

    }
}
