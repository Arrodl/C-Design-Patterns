using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.SOLID.SingleResponsability {
    public class Journal {
        private readonly List<string> entries
            = new List<string>();
        private static int counter = 0;
        /// <sumary>
        /// Add entries to Journal
        /// </sumary>
        public int AddEntry(string entry) {
            entries.Add($"{++counter}: {entry}");
            return counter; // memento
        }
        /// <sumary>
        /// Remove entry at index 
        /// </sumary>
        public void RemoveEntry(int index) => entries.RemoveAt(index);
        /// <sumary>
        /// Send information in string format
        /// </sumary>
        public override string ToString() => string.Join(Environment.NewLine, entries);
    }
}