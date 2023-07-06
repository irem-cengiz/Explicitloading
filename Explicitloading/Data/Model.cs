using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicitloading.Data
{
    public class Model
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Ad { get; set; } = null!;
        public Marka Marka { get; set; } = null!;
        public int MarkaId { get; set; }

    }
}
