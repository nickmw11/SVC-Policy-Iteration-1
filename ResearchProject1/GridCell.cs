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

        public float value;
        public bool isPassable;

        public override string ToString()
        {
            return "[ " + value + " ]";
        }

        public GridCell()
        {
            value = 0;
            isPassable = true;
        }
    }
}
