using System.Xml.Linq;

namespace OpenDocumentCreator;

internal class OpenDocumentManifest : OpenDocumentWritable
{
    internal override string OpenDocumentElementName => "manifest";

    internal override string? NamespaceName => "manifest";

    [OpenDocumentName("version", ElemNamespace = "manifest")]
    public string? Version { get; set; } = null;

    [OpenDocumentName]
    public List<ManifestEntry> Entries { get; set; } = [];

    internal override IEnumerable<XAttribute> NamespaceDefinitions { get; } =
        [
            new XAttribute(XNamespace.Xmlns + "manifest", OpenDocument.Manifest),
        ];
}
