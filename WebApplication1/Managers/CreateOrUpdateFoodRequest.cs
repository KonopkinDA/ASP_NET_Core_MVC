using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateFoodRequest
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Guid MenuForId { get; set; }
    }
}
