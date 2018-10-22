using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject1
{
    class Robot
    {
        public World world = new World();
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

        public void FindOptimalCell()
        {
            float max = 0;
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

            Console.WriteLine("Best Value: " + max + " In direction: " + bestCell.ourOptions.ToString());
        }
    }
}
