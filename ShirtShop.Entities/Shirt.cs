using System;
using System.ComponentModel.DataAnnotations;

namespace ShirtShop.Entities
{
    public class Shirt
    {
        [Key]
        public Guid ShirtId { get; set; }
        public string Name { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public SleeveLength SleeveLength { get; set; }
        public Brand Brand { get; set; }
        public bool EasyIroning { get; set; }
        public decimal Price { get; set; }

        public Shirt(Guid shirtId, string name, 
            Fabric fabric, Size size, Color color, 
            SleeveLength sleeveLength, Brand brand, 
            bool easyIroning, decimal price)
        {
            ShirtId = shirtId;
            Name = name;
            Fabric = fabric;
            Size = size;
            Color = color;
            SleeveLength = sleeveLength;
            Brand = brand;
            EasyIroning = easyIroning;
            Price = price;
        }
    }
}