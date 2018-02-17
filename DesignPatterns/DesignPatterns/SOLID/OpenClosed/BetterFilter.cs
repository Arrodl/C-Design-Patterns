using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    public class BetterFilter : IFilter<Product> {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec) {
            foreach ( var i in items ) {
                if (spec.isSatisfied(i)) {
                    yield return i; // yield is for returning this item and any other that satisfies spec in a collection
                }
            }
        }
    }
}