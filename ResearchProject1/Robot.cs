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
            //if (world.GetCell(pos.x, pos.y).isPassable)
            //{
                position = pos;
            //}
            //else
            //{
            //    Console.WriteLine("NotPassable");
            //}
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

        public double FindOptimalCell(int row, int column)
        {
            position = new Vector(row, column);
            GridCell bestCell;
            option tempOption;
            double max = -999999999;
            double tempValueUp, tempValueDown, tempValueLeft, tempValueRight = 0;

            // bestCell = world.GetCell(position.x + 1, position.y); // to the right

            //  Switch ifs to foreach
            //foreach (option o in option)
            // To do this, we may need to define the enum in a class that implements IEnumerable
            //{


                tempValueLeft = 0.8f * world.GetCell(position.x, position.y, option.LEFT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                    + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value; // left

                tempValueUp = 0.8f * world.GetCell(position.x, position.y, option.UP).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value 
                + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value;

                tempValueDown = 0.8f * world.GetCell(position.x, position.y, option.DOWN).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value
                + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value;

                tempValueRight = 0.8f * world.GetCell(position.x, position.y, option.RIGHT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value;

            //policy.optimalPolicy.Add(bestCell, tempOption);     //  Vector instead of location 

            max = Math.Max(tempValueLeft, Math.Max(tempValueRight, Math.Max(tempValueUp, tempValueDown)));

            //Console.WriteLine("Best Value: " + max + " In direction: " + tempOption.ToString());
            Console.WriteLine(max);

            //if (max == tempValueLeft)
            //{
            //    position.x += -1;
            //    if (position.x < 0)
            //        position.x = 0;
            //}
            //else if (max == tempValueRight)
            //{
            //    position.x += 1;
            //    if (position.x > world.GetWorldLength())
            //        position.x -= 1;
            //}
            //else if (max == tempValueUp)
            //{
            //    position.y -= 1;
            //    if (position.y < 0)
            //        position.y = 0;
            //}
            //else if (max == tempValueDown)
            //{
            //    position.y += 1;
            //    if (position.y > world.GetWorldHeight())
            //        position.y -= 1;
            //}
            return max;
        }
    }
}
