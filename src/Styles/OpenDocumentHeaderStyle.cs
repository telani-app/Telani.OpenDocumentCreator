namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:header-style element specifies the formatting properties for a header element.
///
/// See: 16.6
/// </summary>
public class OpenDocumentHeaderStyle : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "header-style";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// The style:header-footer-properties element specifies formatting properties for both
    /// headers and footers.
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentHeaderFooterProperties> Content { get; private set; } = [];
}
