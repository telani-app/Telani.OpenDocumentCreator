namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:header-footer-properties element specifies formatting properties for both headers and footers.
///
/// The style:header-footer-properties element is usable within the following elements: style:footer-style 16.7 and style:header-style 16.6.
/// </summary>
public class OpenDocumentHeaderFooterProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "header-footer-properties";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// fo:min-height 20.205.2,
    /// </summary>
    [OpenDocumentName("min-height", ElemNamespace = "fo")]
    public Measurement? MinHeight { get; set; } = null;

    /// <summary>
    ///  fo:margin-left 20.200,
    /// </summary>
    [OpenDocumentName("margin-left", ElemNamespace = "fo")]
    public Measurement? MarginLeft { get; set; } = null;

    /// <summary>
    /// fo:margin-right 20.201,
    /// </summary>
    [OpenDocumentName("margin-right", ElemNamespace = "fo")]
    public Measurement? MarginRight { get; set; } = null;

    /// <summary>
    /// fo:margin-top 20.202,
    /// </summary>
    [OpenDocumentName("margin-top", ElemNamespace = "fo")]
    public Measurement? MarginTop { get; set; } = null;

    /// <summary>
    /// fo:margin-bottom 20.199,
    /// </summary>
    [OpenDocumentName("margin-bottom", ElemNamespace = "fo")]
    public Measurement? MarginBottom { get; set; } = null;

    /*
     * The <style:header-footer-properties> element has the following attributes: fo:background-color 20.175,
     * fo:border 20.176.2,
     * fo:border-bottom 20.176.3,
     * fo:border-left 20.176.4,
     * fo:border-right 20.176.5,
     * fo:border-top 20.176.6,
     * fo:margin 20.198,
     * fo:min-height 20.205.2,
     * fo:padding 20.210,
     * fo:padding-bottom 20.211,
     * fo:padding-left 20.212,
     * fo:padding-right 20.213,
     * fo:padding-top 20.214,
     * style:border-line-width 20.241,
     * style:border-line-width-bottom 20.242,
     * style:border-line-width-left 20.243,
     * style:border-line-width-right 20.244,
     * style:border-line-width-top 20.245,
     * style:dynamic- spacing 20.256,
     * style:shadow 20.349
     * svg:height 20.397.2.
     *
     * The <style:header-footer-properties> element has the following child element:
     * <style:background-image> 17.3.
     */
}
