using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    class HTMLBuilder {
        HTMLElement _root = new HTMLElement();
        private readonly string _rootName;

        public HTMLBuilder (string rootName) {
            _root._name = rootName;
            this._rootName = rootName;
        }

        public void AddChild(string childName, string childText) {
            var e = new HTMLElement(childName, childText);
            _root._elements.Add(e);
        }
        
        public override string ToString() {
            return _root.ToString();
        }

        public void Clear() {
            _root = new HTMLElement { _name = _rootName };
        }
    }
}
