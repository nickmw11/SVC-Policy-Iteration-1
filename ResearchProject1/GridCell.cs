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

        public override string ToString()
        {
            if (isPassable == false)
                return "[\tX\t]";

            else
            // "[\t" + value + "\t]";
            return string.Format("[{0:N3}]" + " ", value);
        }

        public GridCell()
        {
            value = 0f;
            isPassable = true;
        }
    }
}
