using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    /// <sumary>
    /// Colors available
    /// </sumary>
    public enum Color {
        Red, Green, Blue
    }
    /// <sumary>
    /// Sizes for products
    /// </sumary>
    public enum Size {
        Small, Medium, Large, Yuge
    }
    public class Product {
        public string _name;
        public Color _color;
        public Size _size;
        /// <sumary> Constructor </sumary>
        public Product(string name, Color color, Size size) {
            this._name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            _color = color;
            _size = size;
        }
    }
}