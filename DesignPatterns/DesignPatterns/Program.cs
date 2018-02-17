using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using DesignPatterns.SOLID.SingleResponsability;
using static System.Console;
using DesignPatterns.SOLID.OpenClosed;

namespace DesignPatterns {
    class Program {
        static void Main (string [] args) {

            var htmlBuilder = new Builder.HTMLBuilder("ul");
            htmlBuilder.AddChild("li", "Hello");
            htmlBuilder.AddChild("li", "world!");

            WriteLine(htmlBuilder.ToString());

            ReadKey();

            var j = new Journal();
            j.AddEntry("I cried today");

            var persistance = new Persistence();
            var filename = @"c:\temp\journal.txt";
            persistance.SaveToFile(j, filename, true);

            Process.Start(filename);

            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            // Metodos de clase
            ProductFilter.FilterBySize(products, Size.Large);

            var bf = new BetterFilter();
            WriteLine("Green products (new) better Filter");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green))) {
                WriteLine($" - {p._name} is {p._color}");
            }

            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large))) {
                WriteLine($" - {p._name} is Large");
            }

            foreach (var p in bf.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Green),
                    new SizeSpecification(Size.Large)))) {
                WriteLine($" - {p._name} is Green and Large");
            }
        } 
    }
}
