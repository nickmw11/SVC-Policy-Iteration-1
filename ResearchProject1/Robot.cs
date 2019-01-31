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

                position = pos;
        }

        public double FindOptimalCell(int row, int column)
        {
            position = new Vector(row, column);
            GridCell bestCell;
            option tempOption;
            double max = -99999999;
            double tempValueUp, tempValueDown, tempValueLeft, tempValueRight = 0;
            option[] foo = { option.UP, option.DOWN, option.LEFT, option.RIGHT };
            //  Dictionary key: tempValue, item: option
            //  Dictionary max to get item out

            //foreach (option o in foo)
            //{
            //    tempValueUp = 0.8f * world.GetCell(position.x, position.y, o).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value
            //        + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value;
            //}

                tempValueUp = 0.8f * world.GetCell(position.x, position.y, option.UP).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value 
                + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value; // up

                tempValueLeft = 0.8f * world.GetCell(position.x, position.y, option.LEFT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value; // left

                tempValueDown = 0.8f * world.GetCell(position.x, position.y, option.DOWN).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value
                + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value; // down

                tempValueRight = 0.8f * world.GetCell(position.x, position.y, option.RIGHT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value;  // right

                


            max = Math.Max(tempValueLeft, Math.Max(tempValueRight, Math.Max(tempValueUp, tempValueDown)));    //Uncomment this to have value iteration working again


            return max;
        }

        public double FindOptimalCell(int row, int column, option o)
        {
            position = new Vector(row, column);

            switch (o)
            {
                case option.UP:
                     return 0.8f * world.GetCell(position.x, position.y, option.UP).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value
                        + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value;

                case option.DOWN:
                    return 0.8f * world.GetCell(position.x, position.y, option.DOWN).value + 0.1f * world.GetCell(position.x, position.y, option.LEFT).value
                        + 0.1f * world.GetCell(position.x, position.y, option.RIGHT).value; // down

                case option.LEFT:
                    return 0.8f * world.GetCell(position.x, position.y, option.LEFT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                        + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value; // left

                case option.RIGHT:
                    return 0.8f * world.GetCell(position.x, position.y, option.RIGHT).value + 0.1f * world.GetCell(position.x, position.y, option.UP).value
                        + 0.1f * world.GetCell(position.x, position.y, option.DOWN).value;  // right

                case option.NONE:
                    return world.GetCell(position.x, position.y).value;

                default:
                    Console.WriteLine("Error in policy iteration");
                    return 0.0f;


            }

            //return max;
        }


    }
}
