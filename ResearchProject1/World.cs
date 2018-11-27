using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class World
    {

        GridCell[,] gridCellTable = new GridCell[10 , 10];  //  Dimensions of world

        public GridCell[,] GetWorld()
        {
            return gridCellTable;
        }

        public int GetWorldLength() //  Get number of rows in world
        {
            return gridCellTable.GetLength(0);
        }

        public int GetWorldHeight() //  Get number of columns in world
        {
            return gridCellTable.GetLength(1);
        }

        public void SetWorld(GridCell[,] newTable)
        {
            gridCellTable = newTable;
        }

        public GridCell GetCell(int row, int column, option action)   //  If out of bounds, get cell currently in
        {                                                             //  Positive value moves right on X axis and down on Y axis
                                                                      //  Negative value moves left on X axis and up on Y axi
            switch (action)
            {
                case option.UP:
                    row--;
                    row = row < 0  || (!gridCellTable[row, column].isPassable)  ? ++row : row;
                    break;

                case option.DOWN:
                    row++;
                    row = row > gridCellTable.GetLength(0) - 1 || (!gridCellTable[row, column].isPassable) ? --row : row;
                    break;

                case option.LEFT:
                    column--;
                    column = column < 0 || (!gridCellTable[row, column].isPassable)  ? ++column : column;
                    break;

                case option.RIGHT:
                    column++;
                    column = column > gridCellTable.GetLength(1) - 1 || (!gridCellTable[row, column].isPassable) ? --column : column;
                    break;
                    
            }

            return gridCellTable[row, column];

        }

        public GridCell GetCell(int row, int column)                  //  Overloaded GetCell to return cell value
        {                                                             //  
                                                                      //  
            return gridCellTable[row, column];

        }


    }
}
