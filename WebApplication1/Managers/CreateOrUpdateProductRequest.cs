using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateProductRequest
    {
        public string Name { get; set; }

        public int Time { get; set; }

        public Guid FoodForId { get; set; }
    }
}
