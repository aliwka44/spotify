﻿namespace Prk1.Models
{
    public class Product: BaseEntity
    {
        public string? Name {  get; set; }
        public string Image { get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
