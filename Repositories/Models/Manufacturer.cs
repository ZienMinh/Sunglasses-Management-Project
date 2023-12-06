using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Sunglasses = new HashSet<Sunglass>();
        }

        public string ManufacturerId { get; set; } = null!;
        public string ManufacturerName { get; set; } = null!;
        public string ManufacturerDescription { get; set; } = null!;

        public virtual ICollection<Sunglass> Sunglasses { get; set; }
    }
}
