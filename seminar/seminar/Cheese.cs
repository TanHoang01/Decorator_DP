using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar
{
    public class Cheese : BurgerDecorator
    {
        public Cheese(IBurger wrappe) : base(wrappe)
        { }
        public override double CountCost()
        {
            return 10 + base.CountCost();
        }
    }
}
