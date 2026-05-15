using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// In text and spreadsheet documents, the style:master-page element contains the content
/// of headers and footers.For these types of documents, consumers may generate a sequence of
/// pages by making use of a single master page or a set of master pages.
///
/// See: 16.9
/// </summary>
/// <remarks>
/// In drawing and presentation documents, the style:master-page element is used to define
/// master pages as common backgrounds for drawing pages.Each drawing page is directly linked to
/// one master page, which is specified by the draw:master-page-name attribute of the drawing
/// pages style.
///
/// Master pages are contained in the office:master-styles element.
///
/// All documents shall contain at least one master page element.
///
/// If a text or spreadsheet document is displayed in a paged layout, master pages are used to
/// generate a sequence of pages containing the document content.When a page is created, an
/// empty page is generated with the properties of the master page and the static content of the
/// master page.The body of the page is then filled with content.A single master pages can be used
/// to created multiple pages within a document.
///
/// In text and spreadsheet documents, a master page can be assigned to paragraph and table styles
/// using a style:master-page-name attribute.Each time the paragraph or table style is applied
/// to text, a page break is inserted before the paragraph or table. A page that starts at the page
/// break position uses the specified master page.
///
/// In drawings and presentations, master pages can be assigned to drawing pages using a
/// style:parent-style-name attribute.
///
/// Note: The OpenDocument paging methodology differs significantly from the methodology used in
/// [XSL]. In XSL, headers and footers are contained within page sequences that also contain the
/// document content.In the OpenDocument format, headers and footers are contained in page
/// styles.With either approach, the content of headers and footers can be changed or omitted
/// without affecting the document content.
/// </remarks>
public class OpenDocumentMasterPage : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "master-page";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// The style:name attribute specifies the name of a master page - each
    /// master page is referenced using the page name. The name specified
    /// shall be unique to the document instance.
    /// </summary>
    [OpenDocumentName("name", ElemNamespace = "style")]
    public string? Name { get; set; }

    /// <summary>
    /// The style:page-layout-name attribute specifies a page layout style that contains sizes,
    /// border and orientation attributes.
    /// </summary>
    /// <remarks>
    /// The style:page-layout-name attribute has the data type styleNameRef 18.3.32.
    /// </remarks>
    [OpenDocumentName("page-layout-name", ElemNamespace = "style")]
    public string? PageLayoutName { get; set; }

    /// <summary>
    /// This element represents the content of a header in a style:masterpage
    /// element.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentHeader? Header { get; set; }

    /// <summary>
    /// This element represents the content for a header for a left page, if
    /// different from the right page in a style:master-page element.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentHeaderLeft? HeaderLeft { get; set; }

    /// <summary>
    /// This element represents the content of a footer in a style:master-page element.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentFooter? Footer { get; set; }

    /// <summary>
    /// This element represents the content for a footer for a left page, if
    /// different from the right page for a style:master-page element.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentFooterLeft? FooterLeft { get; set; }
}
