namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:header element represents the content of a header in a style:masterpage
/// element.
/// </summary>
public class OpenDocumentHeader : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "header";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";
}
