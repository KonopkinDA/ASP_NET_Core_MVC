using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateVerandaRequest
    {
        public string Name { get; set; }

        public string YearTime { get; set; }

        public Guid RestaurantForId { get; set; }
    }
}
