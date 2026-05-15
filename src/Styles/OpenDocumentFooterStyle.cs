using System.Reflection.PortableExecutable;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:footer-style element specifies the formatting properties for a footer element.
///
/// See: 16.7
/// </summary>
public class OpenDocumentFooterStyle : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "footer-style";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// The style:header-footer-properties element specifies formatting properties for both
    /// headers and footers.
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentHeaderFooterProperties> Content { get; private set; } = [];
}
