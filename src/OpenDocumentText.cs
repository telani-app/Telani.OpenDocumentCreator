using System.Text;
using System.Xml.Linq;

namespace OpenDocumentCreator;

/// <summary>
/// Create a OpenDocument Text file. Like any word processor might do.
/// </summary>
public sealed class OpenDocumentText(string creatorName = "") : OpenDocument(creatorName)
{
    /// <inheritdoc/>
    protected override XElement CreateContent()
    {
        var txt = new XElement(
            Office + "text",
            new XAttribute(Text + "use-soft-page-breaks", "true"));

        var paragraph = new XElement(Text + "p"); // should add  text:style-name="P1"
        var text1 = new XElement(Text + "span", "testing");
        paragraph.Add(text1);
        txt.Add(paragraph);

        return txt;
    }

    /// <inheritdoc/>
    protected override string GetMimeType() => "application/vnd.oasis.opendocument.text";

    /// <inheritdoc/>
    protected override void ValidationBeforeSave()
    {
        // None
    }
}
