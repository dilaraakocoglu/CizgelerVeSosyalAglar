using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizgeAlgoritmalarıVeSosyalAglar
{
    public class Pair
    {
        int u, v;

        public Pair(int u, int v)
        {
            this.u = u;
            this.v = v;
        }

        public int U
        {
            get
            {
                return u;
            }
            set
            {
                u = value;
            }
        }

        public int V
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }

        public override string ToString()
        {
            return "(" + u.ToString() + ", " + v.ToString() + ")";
        }
    }
}
