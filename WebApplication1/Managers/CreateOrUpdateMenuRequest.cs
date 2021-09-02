using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Managers
{
    public class CreateOrUpdateMenuRequest
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public Guid VerandaForId { get; set; }
    }
}
