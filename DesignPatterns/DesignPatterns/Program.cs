using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns {
    class Program {
        static void Main (string [] args) {

            var htmlBuilder = new Builder.HTMLBuilder("ul");
            htmlBuilder.AddChild("li", "Hello");
            htmlBuilder.AddChild("li", "world!");

            WriteLine(htmlBuilder.ToString());

            ReadKey();
        }
    }
}
