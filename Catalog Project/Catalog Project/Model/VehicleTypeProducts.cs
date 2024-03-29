﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Catalog_Project.Model
{
    public class VehicleTypeProducts
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Key, Column(Order = 1)]
        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
