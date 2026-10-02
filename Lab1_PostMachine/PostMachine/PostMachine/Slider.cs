using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    public class Slider
    {
        public int position;
        public int Position
        {
            get { return position; }
            private set { position = 0; }
        }
    }
}
