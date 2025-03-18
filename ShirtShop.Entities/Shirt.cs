using System;

namespace ShirtShop.Entities
{
    public class Shirt
    {
        public Guid ShirtId { get; set; }
        public string Name { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public SleeveLength SleeveLength { get; set; }
        public Brand Brand { get; set; }
        public bool EasyIroning { get; set; }
        public decimal Price { get; set; } 
    }
}