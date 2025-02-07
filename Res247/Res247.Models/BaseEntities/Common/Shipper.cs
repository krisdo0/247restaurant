﻿using Res247.Models.BaseEntities;
using Res247.Models.Security;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Res247.Models.Common
{
    [Table("Shippers", Schema = "common")]
    public class Shipper : BaseEntity
    {
        [Required(ErrorMessage = "The {0} is required")]
        public int Status { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        public bool IsActive { get; set; }

        public virtual Account Account { get; set; }

        public virtual ICollection<ShipperOrder> ShipperOrders { get; set; }
    }
}
