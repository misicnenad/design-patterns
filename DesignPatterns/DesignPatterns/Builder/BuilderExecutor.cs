using System;

namespace DesignPatterns.DesignPatterns.Builder
{
    class BuilderExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var rootBuilder = new HtmlElementBuilder("body");
            var htmlElement = rootBuilder
                .AddContainerElement("div")
                    .AddContainerElement("ul")
                        .AddHtmlElement("li", "prvi")
                        .AddHtmlElement("li", "drugi")
                        .BuildContainerElement()
                    .BuildContainerElement()
                .Build();

            Console.WriteLine(htmlElement);
        }
    }
}
