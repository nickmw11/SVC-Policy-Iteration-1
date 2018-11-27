using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    public class GridCell
    {

        public double value;
        public option policy;

        public bool isPassable;
        public bool isGoal;
        public bool isFail;

        public override string ToString()
        {
            if (isPassable == false)
                return "[XXXXXX] ";

            else if (value < 0)
                return string.Format("[{0:N3}]" + " ", value);

            else
            return string.Format("[ {0:N3}]" + " ", value);
        }

        public GridCell()
        {
            value = 0.00f;
            isPassable = true;
        }
    }
}
