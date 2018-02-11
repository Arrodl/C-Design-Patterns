using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    class HTMLElement {

        public string _name, _text;
        public List<HTMLElement> _elements = new List<HTMLElement>();

        private const int _identationSize = 2;

        public HTMLElement () {

        }

        public HTMLElement (string _name, string _text) {
            // Check if values are null
            this._name = _name ?? throw new ArgumentNullException(paramName: nameof(_name));
            this._text = _text ?? throw new ArgumentNullException(paramName: nameof(_text));
        }

        private string ToStringImpl(int _indent) {
            var sb = new StringBuilder();
            var i = new string(' ', _identationSize * _indent);
            sb.Append($"{i}<{_name}>");

            if (!string.IsNullOrWhiteSpace(_text)) {
                sb.Append(new string(' ', _identationSize * (_indent + 1)));
                sb.AppendLine(_text);
            }

            return sb.ToString();
        }

        public override string ToString ()
        {
            return ToStringImpl(0);
        }
    }
}
