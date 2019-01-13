using ExeT4Template.Templates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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

            GenerateClass();

            WriteHtml();
            Console.ReadKey();
        }

        static void WriteHtml()
        {
            string pageContent = (new HtmlTextTemplate()).TransformText();
            using (StreamWriter file = new StreamWriter(@"outputPage.html"))
            {
                file.Write(pageContent);
            }
        }

        static void GenerateClass()
        {
            ClassTemplate ct = new ClassTemplate();

            var tt = ct.TransformText();
            using (StreamWriter file = new StreamWriter(@"MyClass.cs"))
            {
                file.Write(tt);
            }
        }
    }
}
