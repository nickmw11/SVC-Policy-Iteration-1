using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class Robot
    {
        public World world;
        public Vector position = new Vector();
        public Policy policy = new Policy();
        option option;

        public void MoveToPosition(Vector pos)
        {
            if (world.GetCell(pos.x, pos.y).isPassable)
            {
                position = pos;
            }
            else
            {
                Console.WriteLine("NotPassable");
            }
        }

        // double for loop to iterate through 2D array

            // write 1 to all cells - just make sure all loops work

        //public void FindOptimalCell()
        //{
        //    // iterate through all of options 
        //    // get values from World
        //    // calculates the max utility
        //    // writes new utility to the cell it's on
        //    float max = 0;

        public double FindOptimalCell()
        {
            GridCell bestCell;
            option tempOption;
            double max = 0;

            bestCell = world.GetCell(position.x + 1, position.y); // to the right
            tempOption = option.RIGHT;
            max = bestCell.value;

            if (world.GetCell(position.x + -1, position.y).value > max)
            {
                bestCell = world.GetCell(position.x + -1, position.y);// left
                tempOption = option.LEFT;
                max = bestCell.value;

            }
            if (world.GetCell(position.x, position.y - 1).value > max) // up
            {
                bestCell = world.GetCell(position.x, position.y - 1);
                tempOption = option.UP;
                max = bestCell.value;
            }
            if (world.GetCell(position.x, position.y + 1).value > max) // down
            {
                bestCell = world.GetCell(position.x, position.y + 1);
                tempOption = option.DOWN;
                max = bestCell.value;
            }
            policy.optimalPolicy.Add(bestCell, tempOption);

            Console.WriteLine("Best Value: " + max + " In direction: " + tempOption.ToString());
            return max;
        }
    }
}
