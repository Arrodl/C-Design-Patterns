using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

// Creating a new specification
namespace DesignPatterns.SOLID.OpenClosed {
    public class SizeSpecification : ISpecification<Product> {
        private Size _size;
        public SizeSpecification(Size size) => this._size = size;
        public bool isSatisfied(Product t) => t._size == _size;
    }
}