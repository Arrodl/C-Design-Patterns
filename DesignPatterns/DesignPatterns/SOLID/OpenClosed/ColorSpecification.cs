using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    public class ColorSpecification : ISpecification<Product> {
        private Color _color;
        public ColorSpecification(Color color) {
            this._color = color;
        }
        public bool isSatisfied(Product t) {
            return t._color == _color;
        }
    }
}