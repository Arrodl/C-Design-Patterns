using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.SingleResponsability {
    public class Persistence {
        /// <sumary>
        /// Save to file
        /// </sumary>
        public void SaveToFile(Journal journal, string filename, bool overwrite = false) {
            if (overwrite || !File.Exists(filename)) {
                File.WriteAllText(filename, journal.ToString());
            }
        }
    }
}