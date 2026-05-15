namespace OpenDocumentCreator;

/// <summary>
///     draw:image 10.4.4,
///
///     The draw:image element represents an image. An image can be either:
///     * A link to an external resource
///     * or: Embedded in the document
///
///     Note: While the image data may have an arbitrary format, vector graphics should be stored in the
///     [SVG] format and bitmap graphics in the [PNG] format.
/// </summary>
/// <remarks>
///     Missing:
///     --------
///     The draw:image element has the following attributes:
///         * draw:filter-name 19.170
///         * xml:id 19.914
///
///     The draw:image element has the following child elements:
///         * office:binary-data 10.4.5,
///         * text:list 5.3.1,
///         * text:p 5.1.3.
///
/// <code lang="XML">
/// &lt;draw:image
///     xlink:href="media/image1.png"
///     xlink:type="simple"
///     xlink:show="embed"
///     xlink:actuate="onLoad"/&gt;
/// </code>
/// </remarks>
public class OpenDocumentImage : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "image";

    /// <inheritdoc />
    internal override string? NamespaceName => "draw";

    /// <summary>
    /// xlink:href 19.910.15,
    /// </summary>
    [OpenDocumentName("href", ElemNamespace = "xlink")]
    public string? Href { get; set; } = null;

    /// <summary>
    ///  xlink:type 19.913
    ///
    /// See §3.2 of [XLink]. This attribute always has the value
    /// simple in OpenDocument document instances.
    /// </summary>
    [OpenDocumentName("type", ElemNamespace = "xlink")]
    public string Type { get; private set; } = "simple";

    /// <summary>
    ///  xlink:show 19.911,
    ///  See §5.6.1 of [XLink].
    ///
    /// For [..] draw:image 10.4.4[..] elements the value for this attribute is embed.
    ///
    /// </summary>
    [OpenDocumentName("show", ElemNamespace = "xlink")]
    public string Show { get; private set; } = "embed";

    /// <summary>
    ///     xlink:actuate 19.909,
    ///
    ///     See §5.6.2 of [XLink].
    ///
    ///     The xlink:actuate attribute has the value onLoad for the following elements:
    ///     draw:image 10.4.4, [...]
    /// </summary>
    [OpenDocumentName("actuate", ElemNamespace = "xlink")]
    public string Actuate { get; private set; } = "onLoad";
}
