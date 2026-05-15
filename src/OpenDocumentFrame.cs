using System.Text;

namespace OpenDocumentCreator;

/// <summary>
///     draw:frame 10.4.2,
///
///     The `draw:frame` element represents a frame and serves as the container for elements that
///     may occur in a frame.
///
///     Frame formatting properties are stored in styles belonging to the graphic family.
/// </summary>
/// <remarks>
///     Missing:
///     ---------
///
///    The `draw:frame` element has the following attributes:
///    * draw:caption-id 19.115,
///    * draw:class-names 19.120,
///    * draw:copy-of 19.126,
///    * draw:id 19.187.3,
///    * draw:layer 19.189,
///    * draw:transform 19.228,
///    * draw:z-index 19.231,
///    * presentation:class 19.389,
///    * presentation:class-names 19.390,
///    * presentation:placeholder 19.407,
///    * presentation:style-name 19.422,
///    * presentation:user-transformed 19.427,
///    * style:rel-height 19.509,
///    * style:rel-width 19.510.2,
///    * table:end-cell-address 19.627,
///    * table:end-x 19.632,
///    * table:end-y 19.633,
///    * table:table-background 19.728,
///    * text:anchor-page-number 19.753,
///    * text:anchor-type 19.754 and
///    * xml:id 19.914
///
///
///    The `draw:frame` element has the following child elements:
///    * draw:applet 10.4.7,
///    * draw:contour-path 10.4.11.3,
///    * draw:contour-polygon 10.4.11.2,
///    * draw:floating-frame 10.4.10,
///    * draw:glue-point 10.3.16,
///    * draw:image-map 10.4.13.2,
///    * draw:object 10.4.6.2,
///    * draw:object-ole 10.4.6.3,
///    * draw:plugin 10.4.8,
///    * office:event-listeners 10.3.19,
///    * svg:desc 10.3.18,
///    * svg:title 10.3.17 and
///    * table:table 9.1.2.
/// </remarks>
/// <example>
///    for example:
///
///    <code lang="XML">
///       draw:id="id0"
///       draw:style-name="a0"
///       draw:name="Grafik 2"
///       svg:x="0in"
///       svg:y="0in"
///       svg:width="1.25017in"
///       svg:height="1.25017in"
///       style:rel-width="scale"
///       style:rel-height="scale"
///
///       &lt;draw:image
///           xlink:href="media/image1.png"
///           xlink:type="simple"
///           xlink:show="embed"
///           xlink:actuate="onLoad"/&gt;
///       &lt;svg:title/&gt;
///       &lt;svg:desc/&gt;
///     </code>
///
///   </example>
public class OpenDocumentFrame : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "frame";

    /// <inheritdoc />
    internal override string? NamespaceName => "draw";

    /// <summary>
    ///     The draw:z-index attribute defines a rendering order for shapes in a document instance.
    ///     Shapes are rendered in the order in which they appear in the document in the absence of this
    ///     attribute.
    /// </summary>
    [OpenDocumentName("z-index", ElemNamespace = "draw")]
    public int? ZIndex { get; set; } = null;

    /// <summary>
    ///   The draw:id attribute specifies an identifier for an element.
    ///
    ///   The draw:id attribute has the data type NCName 18.2.
    ///
    ///   OpenDocument consumers shall ignore a draw:id attribute if it occurs on a draw element with
    ///   an xml:id attribute value.
    ///
    ///   OpenDocument producers may write draw:id attributes for any draw element in addition to an
    ///   xml:id attribute.
    ///
    ///   The value of a draw:id attribute shall equal the value of an xml:id attribute on the same
    ///   element.
    ///
    ///   The draw:id attribute is deprecated in favor of xml:id. 19.914
    /// </summary>
    [OpenDocumentName("id", ElemNamespace = "draw")]
    public string? DrawingId { get; set; } = null;

    /// <summary>
    /// draw:style-name 19.219.13,
    /// </summary>
    [OpenDocumentName("style-name", ElemNamespace = "draw")]
    public string? StyleName { get; set; } = null;

    /// <summary>
    /// draw:text-style-name 19.227
    /// </summary>
    [OpenDocumentName("text-style-name", ElemNamespace = "draw")]
    public string? TextStyleName { get; set; } = null;

    /// <summary>
    /// draw:name 19.197.10
    /// </summary>
    [OpenDocumentName("name", ElemNamespace = "draw")]
    public string? Name { get; set; } = null;

    /// <summary>
    ///     svg:x 19.573.5,
    /// </summary>
    [OpenDocumentName("x", ElemNamespace = "svg")]
    public Measurement? X { get; set; } = null;

    /// <summary>
    ///    svg:y 19.577.5,
    /// </summary>
    [OpenDocumentName("y", ElemNamespace = "svg")]
    public Measurement? Y { get; set; } = null;

    /// <summary>
    ///     svg:width 19.571.10,
    /// </summary>
    [OpenDocumentName("width", ElemNamespace = "svg")]
    public Measurement? Width { get; set; } = null;

    /// <summary>
    ///     svg:height 19.539.8,
    /// </summary>
    [OpenDocumentName("height", ElemNamespace = "svg")]
    public Measurement? Height { get; set; } = null;

    /// <summary>
    ///     style:rel-width 19.510.2,
    ///
    /// The values of the style:rel-width attribute are a value of type percent 18.3.23, scale or scale-min.
    /// </summary>
    [OpenDocumentName("rel-width", ElemNamespace = "style")]
    public string? RelWidth { get; set; } = null;

    /// <summary>
    ///     style:rel-height 19.509,
    ///
    /// The values of the style:rel-height attribute are a value of type percent 18.3.23, scale or scale-min.
    /// </summary>
    [OpenDocumentName("rel-height", ElemNamespace = "style")]
    public string? RelHeight { get; set; } = null;

    /// <summary>
    ///     draw:image 10.4.4,
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentImage? Image { get; set; } = null;

    /// <summary>
    ///     draw:text-box 10.4.3
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentTextBox? TextBox { get; set; } = null;
}
