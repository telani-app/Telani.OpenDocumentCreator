using System.Collections;
using System.Xml.Linq;

namespace OpenDocumentCreator;

/// <summary>
/// The text:p element represents a paragraph, which is the basic unit of text in an
/// OpenDocument file.
///
/// The text:p element has mixed content.
/// </summary>
/// <remarks>
/// Missing:
/// --------
/// The text:p element has the following attributes:
/// * text:class-names 19.770.3,
/// * text:cond-style-name 19.776,
/// * text:id 19.809.8,
/// * text:style-name 19.874.29,
/// * xhtml:about 19.905,
/// * xhtml:content 19.906,
/// * xhtml:datatype 19.907,
/// * xhtml:property 19.908
/// * xml:id 19.914.
/// </remarks>
public class OpenDocumentParagraph : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "p";

    /// <inheritdoc />
    internal override string? NamespaceName => "text";

    private string? Text { get; set; }

    /// <summary>
    /// text:style-name 19.874.29
    /// </summary>
    [OpenDocumentName("style-name", ElemNamespace = "text")]
    public string? StyleName { get; set; } = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenDocumentParagraph"/> class.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="styleName">The style name to set for this paragraph.</param>
    public OpenDocumentParagraph(string text, string? styleName = null)
    {
        Text = text;
        StyleName = styleName;
    }

    /// <inheritdoc />
    public override string? TextContent()
    {
        return Text;
    }
}
