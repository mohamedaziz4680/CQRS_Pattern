﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Layer.Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }  

    }
}
