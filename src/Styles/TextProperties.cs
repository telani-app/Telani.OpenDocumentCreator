namespace OpenDocumentCreator.Styles;

/// <summary>
/// 16.27.28
/// </summary>
public class TextProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "text-properties";

    /// <summary>
    /// 20.186
    /// </summary>
    [OpenDocumentName("font-weight", ElemNamespace = "fo")]
    public FontWeight? FontWeight { get; set; } = null;

    /// <summary>
    /// 20.180
    /// </summary>
    [OpenDocumentName("color", ElemNamespace = "fo")]
    public Color? Color { get; set; } = null;

    /// <summary>
    /// 20.180
    /// </summary>
    [OpenDocumentName("country", ElemNamespace = "fo")]
    public string? Country { get; set; } = null;

    /// <summary>
    /// 20.175
    /// </summary>
    [OpenDocumentName("background-color", ElemNamespace = "fo")]
    public Color? BackgroundColor { get; set; } = null;

    /// <summary>
    /// 20.182
    /// </summary>
    [OpenDocumentName("font-family", ElemNamespace = "fo")]
    public string? FontFamily { get; set; } = null;

    /// <summary>
    /// 20.183
    /// </summary>
    [OpenDocumentName("font-size", ElemNamespace = "fo")]
    public Measurement? FontSize { get; set; } = null;

    /// <summary>
    /// 20.184
    /// </summary>
    [OpenDocumentName("font-style", ElemNamespace = "fo")]
    public FontStyle? FontStyle { get; set; } = null;

    /// <summary>
    /// 20.185
    /// </summary>
    [OpenDocumentName("font-variant", ElemNamespace = "fo")]
    public string? FontVariant { get; set; } = null;

    /// <summary>
    /// 20.188
    /// </summary>
    [OpenDocumentName("hyphenate", ElemNamespace = "fo")]
    public string? Hyphenate { get; set; } = null;

    /// <summary>
    /// 20.191
    /// </summary>
    [OpenDocumentName("hyphenation-push-char-count", ElemNamespace = "fo")]
    public string? HyphenationPushCharCount { get; set; } = null;

    /// <summary>
    /// 20.192
    /// </summary>
    [OpenDocumentName("hyphenation-remain-char-count", ElemNamespace = "fo")]
    public string? HyphenationRemainCharCount { get; set; } = null;

    /// <summary>
    /// 20.195
    /// </summary>
    [OpenDocumentName("language", ElemNamespace = "fo")]
    public string? Language { get; set; } = null;

    /// <summary>
    /// 20.196
    /// </summary>
    [OpenDocumentName("letter-spacing", ElemNamespace = "fo")]
    public string? LetterSpacing { get; set; } = null;

    /// <summary>
    /// 20.215
    /// </summary>
    [OpenDocumentName("script", ElemNamespace = "fo")]
    public string? Script { get; set; } = null;

    /// <summary>
    /// 20.219
    /// </summary>
    [OpenDocumentName("text-shadow", ElemNamespace = "fo")]
    public string? TextShadow { get; set; } = null;

    /// <summary>
    /// 20.215
    /// </summary>
    [OpenDocumentName("text-transform", ElemNamespace = "fo")]
    public string? TextTransform { get; set; } = null;

    /// <summary>
    /// 20.416
    /// </summary>
    [OpenDocumentName("condition", ElemNamespace = "text")]
    public string? Condition { get; set; } = null;

    /// <summary>
    /// 20.417
    /// </summary>
    [OpenDocumentName("display", ElemNamespace = "text")]
    public string? Display { get; set; } = null;

    /// <summary>
    /// 20.269
    /// </summary>
    [OpenDocumentName("font-name")]
    public string? FontName { get; set; } = null;

    /// <summary>
    /// 20.270
    /// </summary>
    [OpenDocumentName("font-name-asian")]
    public string? FontNameAsian { get; set; } = null;

    /// <summary>
    /// 20.271
    /// </summary>
    [OpenDocumentName("font-name-complex")]
    public string? FontNameComplex { get; set; } = null;

    /// <summary>
    /// 20.276
    /// </summary>
    [OpenDocumentName("font-size-asian")]
    public Measurement? FontSizeAsian { get; set; } = null;

    /// <summary>
    /// 20.277
    /// </summary>
    [OpenDocumentName("font-size-complex")]
    public Measurement? FontSizeComplex { get; set; } = null;

    /// <summary>
    /// 20.248
    /// </summary>
    [OpenDocumentName("country-asian")]
    public string? CountryAsian { get; set; } = null;

    /// <summary>
    /// 20.249
    /// </summary>
    [OpenDocumentName("country-complex")]
    public string? CountryComplex { get; set; } = null;

    /// <summary>
    /// 20.260
    /// </summary>
    [OpenDocumentName("font-charset")]
    public string? FontCharset { get; set; } = null;

    /// <summary>
    /// 20.261
    /// </summary>
    [OpenDocumentName("font-charset-asian")]
    public string? FontCharsetAsian { get; set; } = null;

    /// <summary>
    /// 20.262
    /// </summary>
    [OpenDocumentName("font-charset-complex")]
    public string? FontCharsetComplex { get; set; } = null;

    /// <summary>
    /// 20.380
    /// </summary>
    [OpenDocumentName("text-underline-style")]
    public LineStyle? TextUnderlineStyle { get; set; } = null;

    /// <summary>
    /// 20.381
    /// </summary>
    [OpenDocumentName("text-underline-type")]
    public LineType? TextUnderlineType { get; set; } = null;
}
