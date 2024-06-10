using System.Xml.Linq;

namespace XmlDocumentProcessor
{
    public interface IXmlProcessingStrategy
    {
        void Analyze(XDocument document);
        string TransformToHtml(XDocument document);
    }
}
