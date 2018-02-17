using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    public interface IFilter<T> {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}