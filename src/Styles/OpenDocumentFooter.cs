namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:footer element represents the content of a footer in a style:master-page
/// element.
///
/// See: 16.11
/// </summary>
public class OpenDocumentFooter : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "footer";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";
}
