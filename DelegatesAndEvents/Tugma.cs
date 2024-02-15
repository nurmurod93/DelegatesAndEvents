using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void TugmaDelegati();
    public class Tugma
    {
        public event TugmaDelegati Click;

        public void Simulation()
        {
            if (Click != null) 
            {
                Click();
            }
        }
    }
}
