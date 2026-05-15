using System.Xml.Linq;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The top most level of the styles file. This combines
/// all different styles and other style related components.
/// </summary>
internal class OpenDocumentDocumentStyles : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "document-styles";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenDocumentDocumentStyles"/> class.
    /// </summary>
    public OpenDocumentDocumentStyles()
    {
    }

    /// <summary>
    /// Font face declarations.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentFontFaceDecls? FontFaceDecls { get; set; }

    /// <summary>
    /// The styles.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentStyles? Styles { get; set; }

    /// <summary>
    /// Automatic styles.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentAutomaticStyles? AutomaticStyles { get; set; }

    /// <summary>
    /// The master or template styles.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentMasterStyles? MasterStyles { get; set; }

    /// <inheritdoc />
    internal override IEnumerable<XAttribute> NamespaceDefinitions =>
    [
        new(XNamespace.Xmlns + "table", OpenDocument.Table),
        new(XNamespace.Xmlns + "office", OpenDocument.Office),
        new(XNamespace.Xmlns + "style", OpenDocument.Style),
        new(XNamespace.Xmlns + "text", OpenDocument.Text),
        new(XNamespace.Xmlns + "draw", OpenDocument.Draw),
        new(XNamespace.Xmlns + "fo", OpenDocument.Fo),
        new(XNamespace.Xmlns + "xlink", OpenDocument.XLink),
        new(XNamespace.Xmlns + "dc", OpenDocument.Dc),
        new(XNamespace.Xmlns + "number", OpenDocument.Number),
        new(XNamespace.Xmlns + "svg", OpenDocument.Svg),
        new(XNamespace.Xmlns + "of", OpenDocument.Of),
        new(OpenDocument.Office + "version", "1.2"),
    ];
}
