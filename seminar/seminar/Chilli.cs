using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar
{
    public class Chilli : BurgerDecorator
    {
        public Chilli(IBurger wrappe) : base(wrappe)
        { }
        public override double CountCost()
        {
            return 10 + base.CountCost();
        }
    }
}
