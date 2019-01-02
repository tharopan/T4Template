using System;

namespace ExeT4Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HelloWorldTemplate page = new HelloWorldTemplate();
            String pageContent = page.TransformText(); 

            System.IO.File.WriteAllText("outputPage.html", pageContent);

            Console.ReadKey();
        }
    }
}
