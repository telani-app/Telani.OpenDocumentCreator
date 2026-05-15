using System.Xml;
using System.Xml.Linq;

namespace OpenDocumentCreator.Tests;

[TestClass]
public sealed class OpenDocumentCellTest
{
    private static readonly XNamespace table = XNamespace.Get("urn:oasis:names:tc:opendocument:xmlns:table:1.0");
    private static readonly XNamespace text = XNamespace.Get("urn:oasis:names:tc:opendocument:xmlns:text:1.0");

    [TestMethod]
    public void MultipleWhiteSpace()
    {
        var cell = new OpenDocumentCell("Senken (Aktoren)                           Quellen (Sensoren)");

        var doc = LoadTestXML(cell.CreateElement(), out var nsmanager);

        var path = "/table:table-cell/text:p/text:s";
        var node = doc.SelectSingleNode(path, nsmanager);
        Assert.IsNotNull(node);
        Assert.IsNotNull(node.Attributes);
        var attribute = node.Attributes.GetNamedItem("c", text.NamespaceName);
        Assert.IsNotNull(attribute);
        Assert.AreEqual("26", attribute.InnerText);

    }

    private static XmlDocument LoadTestXML(XElement element, out XmlNamespaceManager nsmanager)
    {
        var xmlString = element.ToString();
        var doc = new XmlDocument();
        nsmanager = new XmlNamespaceManager(doc.NameTable);
        nsmanager.AddNamespace("text", text.NamespaceName);
        nsmanager.AddNamespace("table", table.NamespaceName);

        doc.LoadXml(xmlString);

        return doc;
    }
}
