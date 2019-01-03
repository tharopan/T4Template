using ExeT4Template.Templates;
using System;

namespace ExeT4Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HelloWorldTemplate helloWorld = new HelloWorldTemplate();
            string content = helloWorld.TransformText();
            Console.Write(content);

            WriteHtml();
            Console.ReadKey();
        }

        static void WriteHtml()
        {
            string pageContent = (new HtmlTextTemplate()).TransformText();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"outputPage.html"))
            {
                file.Write(pageContent);
            }
        }
    }
}
