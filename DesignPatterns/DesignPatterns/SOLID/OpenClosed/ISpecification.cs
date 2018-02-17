using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.OpenClosed {
    // El I al inicio es porque es una interfas #nomenclatura
    /// <summary> Template for class </summary>
    public interface ISpecification<T> {
        /// <summary> Checking if class satisfies criteria </summary>
        bool isSatisfied(T t);
    }
}