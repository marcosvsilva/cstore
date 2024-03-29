﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CStore.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? SKU { get; set; }

        public double Price { get; set; }

        [ForeignKey("Categories")]
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        [ForeignKey("Brands")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

    [Table("Brands")]
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }

    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }

    [Table("Favorites")]
    public class Favorite
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
