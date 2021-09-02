using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateCountryRequest
    {
        public string Name { get; set; }

        public string Comment { get; set; }
    }
}
