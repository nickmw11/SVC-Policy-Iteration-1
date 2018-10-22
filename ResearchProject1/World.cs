using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class World
    {
        GridCell[,] gridCellTable = new GridCell[3, 4];  //  Grid of 3 rows, 4 columns

        public GridCell[,] GetWorld()
        {
            return gridCellTable;
        }

        public void SetWorld(GridCell[,] newTable)
        {
            gridCellTable = newTable;
        }

        public GridCell GetCell(int x, int y)
        {
            return gridCellTable[x, y];
        }
    }
}
