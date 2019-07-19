namespace DesignPatterns.DesignPatterns.Builder
{
    class HtmlElementBuilder
    {
        static int _identationIncrement = 2;
        int ChildIdentation { get; set; }

        HtmlElement RootElement { get; set; }
        HtmlElementBuilder ParentBuilder { get; set; }

        public HtmlElementBuilder(string rootTag, int identation = 0, string rootText = null, HtmlElementBuilder parentBuilder = null)
        {
            RootElement = new HtmlElement(rootTag, identation, rootText);
            ParentBuilder = parentBuilder;
            ChildIdentation = identation + _identationIncrement;
        }

        public HtmlElementBuilder AddHtmlElement(string tag, string text = null)
        {
            RootElement.AddChildElement(new HtmlElement(tag, ChildIdentation, text));

            return this;
        }

        public HtmlElementBuilder AddContainerElement(string tag, string text = null)
        {
            var childBuilder = new HtmlElementBuilder(tag, ChildIdentation, text, this);

            return childBuilder;
        }

        public HtmlElementBuilder BuildContainerElement()
        {
            ParentBuilder.AddHtmlElement(RootElement);

            return ParentBuilder;
        }

        public HtmlElement Build()
        {
            return RootElement;
        }

        HtmlElementBuilder AddHtmlElement(HtmlElement element)
        {
            RootElement.AddChildElement(element);

            return this;
        }
    }
}
