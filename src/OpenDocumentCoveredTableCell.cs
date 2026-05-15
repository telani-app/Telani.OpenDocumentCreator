using System.Xml.Linq;

namespace OpenDocumentCreator;

internal sealed class OpenDocumentCoveredTableCell : OpenDocumentWritable
{
    internal override string OpenDocumentElementName => "covered-table-cell";

    internal override string? NamespaceName => "table";

    // There are a lot of instances of this element, we want serialization to be as fast as possible.
    internal override XElement GetElement()
    {
        return new XElement(OpenDocument.Table + OpenDocumentElementName);
    }
}
