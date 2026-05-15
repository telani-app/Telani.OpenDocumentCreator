using System.Xml.Linq;
using OpenDocumentCreator.Styles;

namespace OpenDocumentCreator;

/// <summary>
/// 3.1.3.2
///
/// The office:document-content root element contains document content and automatic
/// styles used in a document.The file within the package for the office:document-content
/// element is content.xml.
///
/// The office:document-content element is a root element.
///
/// Missing:
/// --------
/// * grddl:transformation 19.320
/// * office:version 19.386.
/// * office:scripts 3.12.
/// </summary>
internal class OpenDocumentDocumentContent : OpenDocumentWritable
{
    internal override string OpenDocumentElementName => "document-content";

    internal override string? NamespaceName => "office";

    internal override IEnumerable<XAttribute> NamespaceDefinitions =>
        [
            new XAttribute(XNamespace.Xmlns + "office", OpenDocument.Office),
            new XAttribute(XNamespace.Xmlns + "style", OpenDocument.Style),
            new XAttribute(XNamespace.Xmlns + "text", OpenDocument.Text),
            new XAttribute(XNamespace.Xmlns + "draw", OpenDocument.Draw),
            new XAttribute(XNamespace.Xmlns + "fo", OpenDocument.Fo),
            new XAttribute(XNamespace.Xmlns + "xlink", OpenDocument.XLink),
            new XAttribute(XNamespace.Xmlns + "dc", OpenDocument.Dc),
            new XAttribute(XNamespace.Xmlns + "number", OpenDocument.Number),
            new XAttribute(XNamespace.Xmlns + "svg", OpenDocument.Svg),
            new XAttribute(XNamespace.Xmlns + "of", OpenDocument.Of),
            new XAttribute(XNamespace.Xmlns + "table", OpenDocument.Table),
            new XAttribute(OpenDocument.Office + "version", "1.2"),
        ];

    /// <summary>
    /// office:font-facedecls 3.14
    ///
    /// The office:font-face-decls element contains all the font face declarations
    /// (style:font-face elements) for a document.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentFontFaceDecls? FontFaceDecls { get; set; } = null;

    /// <summary>
    /// office:automatic-styles 3.15.3,
    ///
    /// The office:automatic-styles element contains automatic styles used in a document.
    /// An automatic style is one contains formatting properties that are considered to be properties of
    /// the object to which the style is assigned.
    ///
    /// Note: Common and automatic styles behave differently in OpenDocument editing consumers.
    /// Common styles are presented to the user as a named set of formatting properties.The formatting
    /// properties of an automatic style are presented to a user as properties of the object to which the
    /// style is applied.
    ///
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentAutomaticStyles? AutomaticStyles { get; set; } = null;

    /// <summary>
    /// office:body 3.3,
    ///
    /// The office:body element contains the elements that represent the content of a document.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentBody? Body { get; set; } = null;

    public OpenDocumentDocumentContent()
    {
    }
}
