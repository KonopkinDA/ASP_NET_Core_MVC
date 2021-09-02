using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateRestaurantRequest
    {
        public string Name { get; set; }

        public int Stars { get; set; }

        public Guid CityForId { get; set; }
    }
}
