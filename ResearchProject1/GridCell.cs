using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    public class GridCell
    {
        // Possibly change below variables to properties & implement getters & setters

        public double value;
        public bool isPassable;

        public bool isGoal;
        public bool isFail;

        public override string ToString()
        {
            if (isPassable == false)
                return "[  X  ]";

            else
            // "[\t" + value + "\t]";
            return string.Format("[{0:N3}]" + " ", value);
        }

        public GridCell()
        {
            value = -0.04f;
            isPassable = true;
        }
    }
}
