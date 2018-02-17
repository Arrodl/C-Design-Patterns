using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using DesignPatterns.SOLID.SingleResponsability;
using static System.Console;

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
        }
    }
}
