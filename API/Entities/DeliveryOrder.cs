﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeliveryOrder
    {
        [Key]
        public string delivery_order_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }

        public string delivery_order_date { get; set; }
        public string order_status { get; set; }

        public int expected_quantity { get; set; }
        public int actual_quantity { get; set; }
    }
}
