using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar
{
    public abstract class BurgerDecorator : IBurger
    {
        private IBurger burger;
        protected BurgerDecorator(IBurger wrappee)
        {
            burger = wrappee;
        }
        public virtual double CountCost()
        {
            return burger.CountCost();
        }
    }
}
