using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ResearchProject1
{
    class Program
    {


        static void Main(string[] args)
        {
            //World world = new World();
            //GridCell[,] gridCellTable = world.GetWorld(); // = new GridCell[3,4];  //  Grid of 3 rows, 4 columns
            Robot robot = new Robot();
            World world = new World();
            robot.world = world;

            GridCell[,] gridCellTable = world.GetWorld();
            //while...
            // robot.doCalculation

            Console.WriteLine(gridCellTable.GetLength(0));
            Console.WriteLine(gridCellTable.GetLength(1) + "\n");

            // Initialize this in world class
            for (int i = 0; i < gridCellTable.GetLength(0); i++)    //  Instantiates each cell with default values
            {

                for (int j = 0; j < gridCellTable.GetLength(1); j++)
                {
                    gridCellTable[i, j] = new GridCell();
                }
            }

            gridCellTable[2, 1].isPassable = false;

            robot.MoveToPosition(new Vector(1, 1));
            Console.WriteLine("Position: (" + robot.position.x + "," + robot.position.y + ")");

<<<<<<< HEAD
            robot.world.GetCell(1, 0).value = 1;
            robot.world.GetCell(0, 1).value = 0;
=======
>>>>>>> ef15ca23efb3440cccbdd01e474a268d01efd89e
            //robot.world.GetCell(2, 1).value = 2;

            robot.FindOptimalCell();

            robot.world.SetWorld(gridCellTable);

            printTable(robot.world.GetWorld(), robot);
            Console.ReadLine();
        }

        static void printTable(GridCell[,] table, Robot _robot)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (_robot.position.x == i && _robot.position.y == j)
                    {
                        Console.Write("[\tP\t]");
                    }
                    else
                    {
                        Console.Write(table[i, j].ToString());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
