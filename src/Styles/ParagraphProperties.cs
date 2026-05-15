namespace OpenDocumentCreator.Styles;

/// <summary>
/// This element specifies formatting properties for paragraphs.
/// </summary>
public class ParagraphProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "paragraph-properties";

    /// <summary>
    /// 20.216.1
    /// </summary>
    [OpenDocumentName("text-align", ElemNamespace = "fo")]
    public TextAlign? TextAlign { get; set; } = null;

    /// <summary>
    /// style:line-break 20.307,
    /// </summary>
    [OpenDocumentName("line-break", ElemNamespace = "style")]
    public string? LineBreak { get; set; } = null;

    /// <summary>
    /// Typ Length (magnitude and unit) cm, mm, in, pt, pc, px, em
    ///
    /// 20.200
    /// </summary>
    [OpenDocumentName("margin-left", ElemNamespace = "fo")]
    public Measurement? MarginLeft { get; set; }

    /*
     * Missing:
     *
     * Attribute:
     * fo:background-color 20.175,
     * fo:border 20.176.2,
     * fo:border-bottom 20.176.3,
     * fo:border-left 20.176.4,
     * fo:border-right 20.176.5,
     * fo:border-top 20.176.6,
     * fo:break-after 20.177,
     * fo:break-before 20.178,
     * fo:hyphenation-keep 20.189,
     * fo:hyphenation-ladder-count 20.190,
     * fo:keep-together 20.193,
     * fo:keep-withnext 20.194,
     * fo:line-height 20.197,
     * fo:margin 20.198,
     * fo:margin-bottom 20.199,
     * fo:margin-right 20.201,
     * fo:margin-top 20.202,
     * fo:orphans 20.207,
     * fo:padding 20.210,
     * fo:padding-bottom 20.211,
     * fo:padding-left 20.212,
     * fo:padding-right 20.213,
     * fo:padding-top 20.214,
     * fo:text-align-last 20.217,
     * fo:text-indent 20.218,
     * fo:widows 20.221,
     * style:autotext-indent 20.239,
     * style:background-transparency 20.240,
     * style:border-linewidth 20.241,
     * style:border-line-width-bottom 20.242,
     * style:border-linewidth-left 20.243,
     * style:border-line-width-right 20.244,
     * style:border-linewidth-top 20.245,
     * style:font-independent-line-spacing 20.268,
     * style:joinborder 20.292,
     * style:justify-single-word 20.293,
     * style:line-height-at-least 20.309,
     * style:line-spacing 20.310,
     * style:pagenumber 20.320,
     * style:punctuation-wrap 20.327,
     * style:register-true 20.328,
     * style:shadow 20.349,
     * style:snap-to-layout-grid 20.351,
     * style:tab-stopdistance 20.352,
     * style:text-autospace 20.355,
     * style:vertical-align 20.386.1,
     * style:writing-mode 20.394.4,
     * style:writing-mode-automatic 20.395,
     * text:linenumber 20.420
     * text:number-lines 20.424
     *
     *
     * Children:
     * <style:background-image> 17.3,
     * <style:drop-cap> 17.9
     * <style:tab-stops> 17.7.
     */
}
