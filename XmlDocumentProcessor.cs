using System;
using System.Xml.Linq;

namespace XmlDocumentProcessor
{
    public class XmlDocumentProcessor
    {
        private IXmlProcessingStrategy _strategy;

        public void SetStrategy(IXmlProcessingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessDocument(string xmlFilePath)
        {
            // 1. Завантажити XML-документ.
            XDocument document = XDocument.Load(xmlFilePath);

            // 2. Виконати обробку з використанням вибраної стратегії.
            _strategy.Analyze(document);
            string htmlResult = _strategy.TransformToHtml(document);

            // 3. Вивести результат в консоль або зберегти в файл.
            Console.WriteLine(htmlResult); // Або зберегти в файл
        }
    }
}
