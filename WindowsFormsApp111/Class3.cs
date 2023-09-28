using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp111
{
    class cTarkib
    {

        public int n
        {
            get;
            set;
        }
        public int x
        {
            get;
            set;
        }

        public int Combinition(delFac f)
        {
            return (int)(f(n) / (f(x) * f(n - x)));
        }
    }
        }
    

