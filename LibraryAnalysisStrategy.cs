using System.Linq;
using System;
using System.Xml.Linq;
using System.Net;
using System.Text;

namespace XmlDocumentProcessor
{
    public class LibraryAnalysisStrategy : IXmlProcessingStrategy
    {
        public void Analyze(XDocument document)
        {
            // Пошук інформації за ключовими словами:
            string keyword = "програмування";

            var relevantElements = document.Descendants().Where(e => e.Value.Contains(keyword));

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Елементи з ключовим словом '{keyword}':");
            foreach (var element in relevantElements)
            {
                resultBuilder.AppendLine($"- {element.Name}: {element.Value}");
            }

            // Підрахунок кількості елементів певного типу:
            var books = document.Descendants("book");
            resultBuilder.AppendLine($"Кількість книг: {books.Count()}");

            // Витягнення специфічної інформації з елементів:
            var authors = document.Descendants("author");

            foreach (var author in authors)
            {
                string name = author.Element("name").Value;
                string affiliation = author.Element("affiliation").Value;
                resultBuilder.AppendLine($"Автор: {name}, Афіліація: {affiliation}");
            }

            // Вивести результати
            Console.WriteLine(resultBuilder.ToString());
        }

        public string TransformToHtml(XDocument document)
        {
            // Цей метод не потрібен для даної стратегії, тому повертаємо пустий рядок.
            return "";
        }
    }
}