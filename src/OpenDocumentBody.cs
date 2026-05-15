using System.Xml.Linq;

namespace OpenDocumentCreator;

/// <summary>
/// The office:body element contains the elements that represent the content of a document.
///
///
/// The office:body element has the following child elements:
/// * office:chart 3.8,
/// * office:database 12.1,
/// * office:drawing 3.5,
/// * office:image 3.9,
/// * office:presentation 3.6,
/// * office:spreadsheet 3.7
/// * office:text 3.4.
/// </summary>
internal class OpenDocumentBody : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "body";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// Any of:
    ///
    /// * office:chart 3.8,
    /// * office:database 12.1,
    /// * office:drawing 3.5,
    /// * office:image 3.9,
    /// * office:presentation 3.6,
    /// * office:spreadsheet 3.7,
    /// * office:text 3.4.
    /// </summary>
    [OpenDocumentName("content")]
    public XElement? Content { get; set; } = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenDocumentBody"/> class.
    /// </summary>
    public OpenDocumentBody()
    {
    }
}
