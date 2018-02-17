using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    /// <sumary> Wrong way of doing things </sumary>
    public class ProductFilter {
        /// <sumary> Filtering by size </sumary>
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) {
            foreach (var p in products) {
                if (p._size == size) {
                    yield return p;
                }
            }
        }
    }
}