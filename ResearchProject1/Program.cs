﻿using System;
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

            GridCell[,] gridCellTable = robot.world.GetWorld();

            Console.WriteLine(gridCellTable.GetLength(0));
            Console.WriteLine(gridCellTable.GetLength(1) + "\n");

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

            robot.world.GetCell(0, 3).value = 1;    //  Goal Value
            robot.world.GetCell(1, 3).value = -1;   //  Loss Value
            //robot.world.GetCell(2, 1).value = 2;

            robot.FindOptimalCell();

            robot.world.SetWorld(gridCellTable);

            printTable(robot.world.GetWorld(), robot);
            Console.ReadLine();

            for (int outerLoop = 0; outerLoop < 5; outerLoop++) //  This will eventually loop until numbers converge
            {
                for (int i = 0; i < gridCellTable.GetLength(0); i++)
                {

                    for (int j = 0; j < gridCellTable.GetLength(1); j++)
                    {
                        if ((i != 0 && j != 3) && (i != 1 && j != 3))
                            robot.world.GetCell(i, j).value = -0.04 + robot.FindOptimalCell();
                    }
                }
                printTable(robot.world.GetWorld(), robot);
                Console.WriteLine();
            }

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
