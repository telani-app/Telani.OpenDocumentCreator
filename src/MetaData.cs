using System.Globalization;
using System.Xml.Linq;

namespace OpenDocumentCreator;

internal class OpenDocumentMetaData
{
    public string Generator { get; set; }

    public string Creator { get; set; }

    public OpenDocumentMetaData(string creator = "", string generator = "")
    {
        Generator = generator;
        Creator = creator;
    }

    public XDocument XmlMeta
    {
        get
        {
            XNamespace office = XNamespace.Get("urn:oasis:names:tc:opendocument:xmlns:office:1.0");
            XNamespace meta = XNamespace.Get("urn:oasis:names:tc:opendocument:xmlns:meta:1.0");
            XNamespace dc = XNamespace.Get("http://purl.org/dc/elements/1.1/");
            XNamespace xlink = XNamespace.Get("http://www.w3.org/1999/xlink");

            var root = new XElement(
                office + "document-meta",
                new XAttribute(XNamespace.Xmlns + "office", office),
                new XAttribute(XNamespace.Xmlns + "meta", meta),
                new XAttribute(XNamespace.Xmlns + "dc", dc),
                new XAttribute(XNamespace.Xmlns + "xlink", xlink),
                new XAttribute(office + "version", "1.2"));
            var currentTime = DateTime.Now;
            var timeString = currentTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
            var container = new XElement(
                office + "meta",
                new XElement(meta + "generator", new XText(Generator)),
                new XElement(meta + "initial-creator", new XText(Creator)),
                new XElement(dc + "creator", new XText(Creator)),
                new XElement(meta + "creation-date", new XText(timeString)),
                new XElement(dc + "date", new XText(timeString)),
                new XElement(meta + "editing-duration", new XText("PT0S")));
            root.Add(container);
            var metaDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            return metaDocument;
        }
    }
}
