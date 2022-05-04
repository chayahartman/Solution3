using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
   public class Clothes
    {
        public int ClothId { get; set; }
        public string ClothName { get; set; }
        public int? CategoryId { get; set; }
        public double? ClothPrice { get; set; }
        public string ClothPic { get; set; }
        public string ClothColor { get; set; }
        public int? ClothSize { get; set; }
        public int? ClothAmount { get; set; }
    }
}
