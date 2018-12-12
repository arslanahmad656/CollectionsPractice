using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.BoxCollectionExample
{
    /// <summary>
    /// This is the class whose enumerable collection is to be made
    /// </summary>
    public class Box : IEquatable<Box>
    {
        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Equals(Box other)
        {
            return this == other || (other != null && this.Length == other.Length && this.Width == other.Width && this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Box {Length} x {Width} x {Height}";
        }
    }
}
