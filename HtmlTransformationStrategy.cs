using System.Xml.Linq;
using System.Text;
using System.Net;

namespace XmlDocumentProcessor
{
    public class HtmlTransformationStrategy : IXmlProcessingStrategy
    {
        public void Analyze(XDocument document)
        {
            // Цей метод не потрібен для даної стратегії.
        }

        public string TransformToHtml(XDocument document)
        {
            StringBuilder html = new StringBuilder();
            html.Append("<html><head><style>body { font-family: sans-serif; }</style></head><body>");

            foreach (var element in document.Descendants())
            {
                html.Append($"<{element.Name.LocalName}");
                foreach (var attribute in element.Attributes())
                {
                    html.Append($" {attribute.Name}=\"{attribute.Value}\"");
                }

                if (element.IsEmpty)
                {
                    html.Append(" />");
                }
                else
                {
                    html.Append(">");
                    string escapedValue = WebUtility.HtmlEncode(element.Value);
                    html.Append(escapedValue);
                    html.Append($"</{element.Name.LocalName}>");
                }
            }

            html.Append("</body></html>");
            return html.ToString();
        }
    }
}