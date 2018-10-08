using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ResearchProject1
{
    class Program
    {
        enum options { UP, DOWN, LEFT, RIGHT };
        
        static void Main(string[] args)
        {

            GridCell[,] gridCellTable = new GridCell[3,4];  //  Grid of 3 rows, 4 columns

            Console.WriteLine(gridCellTable.GetLength(0));
            Console.WriteLine(gridCellTable.GetLength(1) + "\n");

            for (int i = 0; i < gridCellTable.GetLength(0); i++)    //  Instantiates each cell with default values
            {
                
                for(int j = 0; j < gridCellTable.GetLength(1); j++)
                {
                    gridCellTable[i, j] = new GridCell();
                }
            }

            gridCellTable[1, 1].isPassable = false;

            void printTable(GridCell[,] table)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {

                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write(table[i, j].ToString());
                    }
                    Console.WriteLine();
                }
            }

            printTable(gridCellTable);
        }


    }
}
