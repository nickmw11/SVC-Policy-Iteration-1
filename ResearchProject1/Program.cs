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
            double delta = 0;
            double desiredDelta = 0.001f;

            double discountFactor = 1.0f;
            double rewardValue = -0.04f;

            long loopCount = 0; //  Number of iterations to reach desired delta value

            Robot robot = new Robot();
            World world = new World();
            robot.world = world;

            World policy = new World();

            GridCell[,] gridCellTable = world.GetWorld();

            //  Output size of world to console
            Console.WriteLine("World Rows: " + gridCellTable.GetLength(0));
            Console.WriteLine("World Columns: " + gridCellTable.GetLength(1) + "\n");

            //  Instantiates each cell with default values
            for (int i = 0; i < gridCellTable.GetLength(0); i++)    
            {

                for (int j = 0; j < gridCellTable.GetLength(1); j++)
                {
                    gridCellTable[i, j] = new GridCell();
                }

            }

            //  World definition - Should move towards parsing this from another file such at bitmap
            gridCellTable[0, 9].value = 1;    //  Goal Value
            gridCellTable[0, 9].isGoal = true;
            gridCellTable[2, 9].value = -1;   //  Loss Value
            gridCellTable[2, 9].isFail = true;
            gridCellTable[9, 4].isPassable = false;
            gridCellTable[5, 5].isPassable = false;

            //  Set robot to current world
            robot.world.SetWorld(gridCellTable);

            //  Print initial world
            printTable(robot.world.GetWorld(), robot);

            Console.ReadLine();

            while (true)
            {
                delta = 0;
                for (int i = 0; i < gridCellTable.GetLength(0); i++)    //
                {

                    for (int j = 0; j < gridCellTable.GetLength(1); j++)    //  Iterates across each cell in world
                    {
                        loopCount++;

                        if (!gridCellTable[i, j].isPassable || gridCellTable[i, j].isGoal || gridCellTable[i,j].isFail) //  If the cell isn't passable, is a goal cell, or a fail cell, don't calculate value
                            continue;

                        double oldValue = gridCellTable[i, j].value;
                        gridCellTable[i, j].value = rewardValue + (discountFactor * robot.FindOptimalCell(i, j));     // Bellman update
                        delta = Math.Max(delta, Math.Abs(gridCellTable[i, j].value - oldValue));

                    }


                }
                if (Math.Abs(delta) <= desiredDelta)  //  Once delta reaches desired value, stop
                {
                    break;
                }

                printTable(robot.world.GetWorld(), robot);
                Console.WriteLine("\n");
                if (loopCount % 20 == 0)
                {
                }

            }

            Console.WriteLine("Loop count: " + loopCount);
            printTable(robot.world.GetWorld(), robot);

        }

        static void printTable(GridCell[,] table, Robot _robot)
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

    }
}
