namespace OpenDocumentCreator.Styles;

/// <summary>
/// 3.14
///
/// The office:font-face-decls element contains all the font face declarations (style:font-face elements) for a document.
///
/// The office:font-face-decls element is usable within the following elements:
/// * office:document 3.1.2
/// * office:document-content 3.1.3.2 and
/// * office:document-styles 3.1.3.3.
/// </summary>
internal class OpenDocumentFontFaceDecls : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "font-face-decls";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// The office:font-face-decls element has the following child element: style:font-face 16.21.
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentFontFace> Content { get; } = [];
}
