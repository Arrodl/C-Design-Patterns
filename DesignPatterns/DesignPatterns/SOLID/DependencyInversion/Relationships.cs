using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.SOLID.DependencyInversion {
    public class Relationships : IRelationshipBrowser {
        private List<(Person, Relationship, Person)> relations 
            = new List<(Person, Relationship, Person)>();
        public void AddParentAddChild (Person parent, Person child) {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
        public IEnumerable<Person> FindAllChildrenOf(string name) {
            return relations.Where(
                x=> x.Item1._name == name &&
                    x.Item2 == Relationship.Parent
            ).Select(r => r.Item3);
        }
    }
}