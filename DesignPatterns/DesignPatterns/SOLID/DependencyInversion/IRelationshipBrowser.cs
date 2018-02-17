using System.Collections.Generic;

namespace DesignPatterns.SOLID.DependencyInversion {
    public interface IRelationshipBrowser {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}