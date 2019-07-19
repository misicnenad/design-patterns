using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Builder
{
    class HtmlElement
    {
        readonly string _tag;
        readonly string _text;
        readonly int _identation;

        ICollection<HtmlElement> _children;

        public HtmlElement(string tag, int identation = 0, string text = null)
        {
            _tag = tag;
            _text = text;
            _identation = identation;
            _children = new List<HtmlElement>();
        }

        public void AddChildElement(HtmlElement element)
        {
            _children.Add(element);
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            var indentation = new string(' ', _identation);
            var newLine = Environment.NewLine;

            str.Append($"{indentation}<{_tag}>{newLine}");
            if (!string.IsNullOrEmpty(_text))
            {
                str.Append($"{indentation}  {_text}{newLine}");
            }

            foreach (var element in _children)
            {
                str.Append($"{element}{newLine}");
            }
            str.Append($"{indentation}</{_tag}>");

            return str.ToString();
        }
    }
}
