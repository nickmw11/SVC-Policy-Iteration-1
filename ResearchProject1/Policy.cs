using System.Collections.Generic;

namespace ResearchProject1
{
    public class Policy
    {
        public Dictionary<GridCell, option> optimalPolicy;

        public Policy()
        {
            optimalPolicy = new Dictionary<GridCell, option>();
        }
    }
}