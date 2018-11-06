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
            return "[\t" + value + "\t]";
        }

        public GridCell()
        {
            value = 0f;
            isPassable = true;
        }
    }
}
