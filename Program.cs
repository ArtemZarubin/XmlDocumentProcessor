using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDocumentProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Створити об'єкт XmlDocumentProcessor.
            XmlDocumentProcessor processor = new XmlDocumentProcessor();

            // 2. Вибрати стратегію.
            // Для аналізу:
            processor.SetStrategy(new LibraryAnalysisStrategy());
            // Для перетворення в HTML:
            // processor.SetStrategy(new HtmlTransformationStrategy());

            // 3. Вказати шлях до XML-файлу.
            string xmlFilePath = "D:\\Visual Studio\\Projects\\XmlDocumentProcessor\\books.xml";

            // 4. Обробка XML-документа.
            processor.ProcessDocument(xmlFilePath);

            Console.WriteLine("Обробка завершена.");
            Console.ReadLine(); // Затримати консоль
        }
    }
}
