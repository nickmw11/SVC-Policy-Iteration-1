using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class World
    {
        //public int rows = 3;
        //public int columns = 4;

        GridCell[,] gridCellTable = new GridCell[3 , 4];  //  Grid of 3 rows, 4 columns

        public GridCell[,] GetWorld()
        {
            return gridCellTable;
        }

        public int GetWorldLength()
        {
            return gridCellTable.GetLength(0);
        }

        public int GetWorldHeight()
        {
            return gridCellTable.GetLength(1);
        }

        public void SetWorld(GridCell[,] newTable)
        {
            gridCellTable = newTable;
        }

        public GridCell GetCell(int row, int column, option action)   //  if out of bounds, get cell currently in.  Need to incorporate isPassable into this
        {
            switch (action)
            {
                case option.UP:
                    row--;
                    row = row < 0  || (!gridCellTable[row, column].isPassable)  ? ++row : row;
                    break;

                case option.DOWN:
                    row++;
                    //row = row > gridCellTable.GetLength(1) - 1 ? row : gridCellTable.GetLength(1) - 1;
                    row = row > gridCellTable.GetLength(0) - 1 || (!gridCellTable[row, column].isPassable) ? --row : row;
                    break;

                case option.LEFT:
                    column--;
                    column = column < 0 || (!gridCellTable[row, column].isPassable)  ? ++column : column;
                    break;

                case option.RIGHT:
                    column++;
                    //column = column > gridCellTable.GetLength(1) - 1 ? column : gridCellTable.GetLength(0) - 1;
                    column = column > gridCellTable.GetLength(1) - 1 || (!gridCellTable[row, column].isPassable) ? --column : column;
                    break;

                //default:
                //    Console.WriteLine("Something went wrong!");
                    
            }

            //Console.WriteLine("Row: " + row + " Column: " + column);
            return gridCellTable[row, column];

        }

        //public GridCell GetCellUtilityFromOption(Vector robotPosition, option option)
        //{
        //    return cell value
        //}
    }
}
