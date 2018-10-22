using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class GridCell
    {
        // options ourOptions;
        // Possibly change below variables to properties & implement getters & setters
        public enum options { UP, DOWN, LEFT, RIGHT };
        public options ourOptions;
        public float value;
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
            value = -0.04f;
            isPassable = true;
        }
    }
}
