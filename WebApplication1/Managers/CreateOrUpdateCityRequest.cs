using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateCityRequest
    {
        public string Name { get; set; }

        public int People { get; set; }

        public Guid CountryForId { get; set; }
    }
}
