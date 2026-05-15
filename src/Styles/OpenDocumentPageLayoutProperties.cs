namespace OpenDocumentCreator.Styles;

/// <summary>
/// 17.2
///
/// The style:page-layout-properties element acts as a container for attributes and elements that define a page layout.
///
/// The style:page-layout-properties element is usable within the following elements: style:default-page-layout 16.8 and style:page-layout 16.5.
/// </summary>
public class OpenDocumentPageLayoutProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "page-layout-properties";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

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
    /// style:table-centering 20.353
    /// </summary>
    [OpenDocumentName("table-centering", ElemNamespace = "style")]
    public TableCentering? TableCentering { get; set; } = null;

    /// <summary>
    /// style:print 20.322,
    /// </summary>
    /// <value>The print.</value>
    [OpenDocumentName("print", ElemNamespace = "style")]
    public string? Print { get; set; } = null;

    /*
     * The <style:page-layout-properties> element has the following attributes:
     * fo:background-color 20.175,
     * fo:border 20.176.2,
     * fo:border-bottom 20.176.3,
     * fo:border-left 20.176.4,
     * fo:border-right 20.176.5,
     * fo:border-top 20.176.6,
     * fo:margin 20.198,
     * fo:padding 20.210,
     * fo:padding-bottom 20.211,
     * fo:padding-left 20.212,
     * fo:padding-right 20.213,
     * fo:padding-top 20.214,
     * fo:page-height 20.208,
     * fo:page-width 20.209,
     * style:border-line-width 20.241,
     * style:border-line-width-bottom 20.242,
     * style:border-line-width-left 20.243,
     * style:border-line-width-right 20.244,
     * style:border-line-width-top 20.245,
     * style:first-page-number 20.258,
     * style:footnote-max-height 20.288,
     * style:layout-grid-base-height 20.296,
     * style:layout-grid-base-width 20.297,
     * style:layout-grid-color 20.298,
     * style:layout-grid-display 20.299,
     * style:layout-grid-lines 20.300,
     * style:layout-grid-mode 20.301,
     * style:layout-grid-print 20.302,
     * style:layout-grid-ruby-below 20.303,
     * style:layout-grid-ruby-height 20.304,
     * style:layout-grid-snap-to 20.305,
     * style:layout-grid- standard-mode 20.306,
     * style:num-format 20.314,
     * style:num-letter-sync 20.315,
     * style:num-prefix 20.316,
     * style:num-suffix 20.317,
     * style:paper-tray-name 20.321,
     * style:print-orientation 20.325,
     * style:print-page-order 20.324,
     * style:register-truth-ref-style-name 20.329,
     * style:scale-to 20.344,
     * style:scale-to-pages 20.345, style:shadow 20.349,
     * style:writing-mode 20.394.3.

        The <style:page-layout-properties> element has the following child elements:
     *  <style:background-image> 17.3,
     *  <style:columns> 17.12 and
     *  <style:footnote-sep> 17.4.
    */
}
