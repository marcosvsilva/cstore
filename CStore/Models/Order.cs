﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CStore.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public double Total { get; set; }

        public User User { get; set; }

        public Payment Payment { get; set; }

        public ICollection<Item> Items { get; set; }
    }

    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double Discount { get; set; }

        public double TotalPrice { get; set; }

        public Product Product { get; set; }
    }
}