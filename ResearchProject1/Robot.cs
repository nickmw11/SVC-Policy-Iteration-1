using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    //class Policy
    //{
    //    Dictionary<GridCell, option> optimalPolicy;
    //}

    class Robot
    {
        public World world;
        public Vector position = new Vector();

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

<<<<<<< HEAD
        // double for loop to iterate through 2D array

            // write 1 to all cells - just make sure all loops work

        public void FindOptimalCell()
        {
            // iterate through all of options 
            // get values from World
            // calculates the max utility
            // writes new utility to the cell it's on
            float max = 0;
=======
        public double FindOptimalCell()
        {
            double max = 0;
>>>>>>> ef15ca23efb3440cccbdd01e474a268d01efd89e
            GridCell bestCell;
            bestCell = world.GetCell(position.x + 1, position.y); // to the right
            bestCell.ourOptions = GridCell.options.RIGHT;
            max = bestCell.value;
            if (world.GetCell(position.x + -1, position.y).value > max)
            {
                bestCell = world.GetCell(position.x + -1, position.y);// left
                bestCell.ourOptions = GridCell.options.LEFT;
                max = bestCell.value;

            }
            if (world.GetCell(position.x, position.y - 1).value > max) // up
            {
                bestCell = world.GetCell(position.x, position.y - 1);
                bestCell.ourOptions = GridCell.options.UP;
                max = bestCell.value;
            }
            if (world.GetCell(position.x, position.y + 1).value > max) // down
            {
                bestCell = world.GetCell(position.x, position.y + 1);
                bestCell.ourOptions = GridCell.options.DOWN;
                max = bestCell.value;
            }

            //Console.WriteLine("Best Value: " + max + " In direction: " + bestCell.ourOptions.ToString());
            return max;
        }
    }
}
