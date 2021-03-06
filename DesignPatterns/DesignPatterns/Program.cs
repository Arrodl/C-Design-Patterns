﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using DesignPatterns.SOLID.SingleResponsability;
using DesignPatterns.SOLID.LiskovSubstitution;
using static System.Console;
using DesignPatterns.SOLID.OpenClosed;
using DesignPatterns.Observer;

namespace DesignPatterns {
    class Program {
        static void Main (string [] args) {

            //var htmlBuilder = new Builder.HTMLBuilder("ul");
            //htmlBuilder.AddChild("li", "Hello");
            //htmlBuilder.AddChild("li", "world!");

            //WriteLine(htmlBuilder.ToString());

            //ReadKey();

            //var j = new Journal();
            //j.AddEntry("I cried today");

            //var persistance = new Persistence();
            ////persistance.SaveToFile(j, filename, true);

            ////Process.Start(filename);

            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Large);

            //Product[] products = { apple, tree, house };

            //// Metodos de clase
            //ProductFilter.FilterBySize(products, Size.Large);

            //var bf = new BetterFilter();
            //WriteLine("Green products (new) better Filter");
            //foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green))) {
            //    WriteLine($" - {p._name} is {p._color}");
            //}

            //foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large))) {
            //    WriteLine($" - {p._name} is Large");
            //}

            //foreach (var p in bf.Filter(
            //    products,
            //    new AndSpecification<Product>(
            //        new ColorSpecification(Color.Green),
            //        new SizeSpecification(Size.Large)))) {
            //    WriteLine($" - {p._name} is Green and Large");
            //}

            //var rect = new Rectangle(12,12);

            //// Liskov

            //Rectangle rc = new Rectangle(2, 3);
            //WriteLine($"{rc} has area {Area(rc)}");

            //Rectangle sq = new Square {
            //    _width = 4
            //};
            //WriteLine($"{sq} has area {Area(sq)}");

            //ReadKey();

            var person = new Person();

            person.FallsIll += CallDoctor;

            person.CatchACold();

            ReadKey();
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs) {
            WriteLine($"A doctor has been caled to {eventArgs.Address}");
        }

        static public int Area(Rectangle r) => r._width * r._height;
    }
}
