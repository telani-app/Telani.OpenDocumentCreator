namespace OpenDocumentCreator.Styles;

/// <summary>
/// Usable in default-style and style
/// </summary>
public class TableCellProperties : OpenDocumentWritable
{
    /// <inheritdoc/>
    internal override string OpenDocumentElementName => "table-cell-properties";

    /// <summary>
    /// The style:text-align-source attribute specifies the source of a text-align attribute.
    /// </summary>
    [OpenDocumentName("text-align-source")]
    public TextAlignSource? TextAlignSource { get; set; } = null;

    /// <summary>
    /// The style:repeat-content attribute specifies whether text content of a cell is displayed as
    /// many times as there is space left in the cell's writing direction. The attribute has no effect for cell
    /// content that contains a line break.
    /// </summary>
    /// <remarks>
    /// The defined values for the style:repeat-content attribute are:
    ///
    /// * false: text content of a cell should not be displayed as many times as there is space left in
    /// the cell's writing direction.
    /// * true: text content of a cell should be displayed as many times as there is space left in the
    /// cell's writing direction.
    /// </remarks>
    [OpenDocumentName("repeat-content")]
    public OpenDocBoolean? RepeatContent { get; set; } = null;

    /// <summary>
    /// Type is a 18.3.1 angle, double value that may be followed immediately
    /// by one of the following: deg, grad, rad if no unit is specified deg is assumed
    /// </summary>
    [OpenDocumentName("rotation-angle")]
    public string? RotationAngle { get; set; } = null;

    /// <summary>
    /// The style:vertical-align attribute specifies the vertical alignment of text in a table cell.
    /// </summary>
    /// <remarks>
    /// The options for the vertical alignment attribute are as follows:
    /// * automatic: consumer determines how to align the text.
    /// * bottom: aligns text vertically with the bottom of the cell.
    /// * middle: aligns text vertically with the middle of the cell.
    /// * top: aligns text vertically with the top of the cell.
    /// </remarks>
    [OpenDocumentName("vertical-align")]
    public VerticalAlign? VerticalAlign { get; set; } = null;

    /// <summary>
    /// See §7.29.3 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:border attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("border", ElemNamespace = "fo")]
    public CompoundLine? Border { get; set; } = null;

    /// <summary>
    /// See §7.29.4 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:border-bottom attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("border-bottom", ElemNamespace = "fo")]
    public CompoundLine? BorderBottom { get; set; } = null;

    /// <summary>
    /// See §7.29.6 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:border-left attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("border-left", ElemNamespace = "fo")]
    public CompoundLine? BorderLeft { get; set; } = null;

    /// <summary>
    /// See §7.29.7 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:border-right attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("border-right", ElemNamespace = "fo")]
    public CompoundLine? BorderRight { get; set; } = null;

    /// <summary>
    /// See §7.29.10 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:border-top attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("border-top", ElemNamespace = "fo")]
    public CompoundLine? BorderTop { get; set; } = null;

    /// <summary>
    /// See §7.29.15 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:padding attribute has the data type nonNegativeLength 18.3.20.
    /// </remarks>
    [OpenDocumentName("padding", ElemNamespace = "fo")]
    public string? Padding { get; set; } = null;

    /// <summary>
    /// See §7.7.36 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:padding-bottom attribute has the data type nonNegativeLength 18.3.20.
    /// </remarks>
    [OpenDocumentName("padding-bottom", ElemNamespace = "fo")]
    public string? PaddingBottom { get; set; } = null;

    /// <summary>
    /// See §7.7.37 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:padding-left attribute has the data type nonNegativeLength 18.3.20.
    /// </remarks>
    [OpenDocumentName("padding-left", ElemNamespace = "fo")]
    public string? PaddingLeft { get; set; } = null;

    /// <summary>
    /// See §7.7.38 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:padding-right attribute has the data type nonNegativeLength 18.3.20.
    /// </remarks>
    [OpenDocumentName("padding-right", ElemNamespace = "fo")]
    public string? PaddingRight { get; set; } = null;

    /// <summary>
    /// See §7.7.35 of [XSL].
    /// </summary>
    /// <remarks>
    /// The fo:padding-top attribute has the data type nonNegativeLength 18.3.20.
    /// </remarks>
    [OpenDocumentName("padding-top", ElemNamespace = "fo")]
    public string? PaddingTop { get; set; } = null;

    /// <summary>
    /// list of three white space-separated lengths, as follows:
    /// * The first value specifies the width of the inner line
    /// * The second value specifies the distance between the two lines
    /// * The third value specifies the width of the outer line
    /// </summary>
    [OpenDocumentName("border-line-width")]
    public string? BorderLineWidth { get; set; } = null;

    /// <summary>
    /// list of three white space-separated lengths, as follows:
    /// * The first value specifies the width of the inner line
    /// * The second value specifies the distance between the two lines
    /// * The third value specifies the width of the outer line
    /// </summary>
    [OpenDocumentName("border-line-width-bottom")]
    public string? BorderLineWidthBottom { get; set; } = null;

    /// <summary>
    /// list of three white space-separated lengths, as follows:
    /// * The first value specifies the width of the inner line
    /// * The second value specifies the distance between the two lines
    /// * The third value specifies the width of the outer line
    /// </summary>
    [OpenDocumentName("border-line-width-left")]
    public string? BorderLineWidthLeft { get; set; } = null;

    /// <summary>
    /// list of three white space-separated lengths, as follows:
    /// * The first value specifies the width of the inner line
    /// * The second value specifies the distance between the two lines
    /// * The third value specifies the width of the outer line
    /// </summary>
    [OpenDocumentName("border-line-width-right")]
    public string? BorderLineWidthRight { get; set; } = null;

    /// <summary>
    /// list of three white space-separated lengths, as follows:
    /// * The first value specifies the width of the inner line
    /// * The second value specifies the distance between the two lines
    /// * The third value specifies the width of the outer line
    /// </summary>
    [OpenDocumentName("border-line-top")]
    public string? BorderLineWidthTop { get; set; } = null;

    /// <summary>
    /// This attribute is only evaluated if the current table is protected.
    /// </summary>
    [OpenDocumentName("cell-protect")]
    public CellProtectionLevel? CellProtect { get; set; } = null;

    /// <summary>
    /// Specifies the maximum number of decimal places that are displayed if numbers are formatted
    /// by a data style that has no setting for number of decimal places itself.
    ///
    /// This attribute is only evaluated if it is contained in a default style.
    /// </summary>
    [OpenDocumentName("decimal-places")]
    public string? DecimalPlaces { get; set; } = null;

    /// <summary>
    /// specifies the style of border to use for a bottom-left to top-right diagonal in a spreadsheet cell.
    /// </summary>
    [OpenDocumentName("diagonal-bl-tr")]
    public CompoundLine? DiagonalBottomLeftTopRight { get; set; } = null;

    /// <summary>
    /// specifies the width between a double line border to use for a bottom-left to top-right diagonal in a spreadsheet cell.
    /// The values are three white space separated values of type positiveLength
    /// </summary>
    [OpenDocumentName("diagonal-bl-tr-widths")]
    public CompoundLine? DiagonalBottomLeftTopRightWidths { get; set; } = null;

    /// <summary>
    /// specifies the style of border to use for a bottom-left to top-right diagonal in a spreadsheet cell.
    /// </summary>
    [OpenDocumentName("diagonal-tl-br")]
    public CompoundLine? DiagonalTopLeftBottomRight { get; set; } = null;

    /// <summary>
    /// specifies the width between a double line border to use for a top-left to bottom-right diagonal in a spreadsheet cell.
    /// The values are three white space separated values of type positiveLength
    /// </summary>
    [OpenDocumentName("diagonal-tl-br-widths")]
    public CompoundLine? DiagonalTopLeftBottomRightWidths { get; set; } = null;

    /// <summary>
    /// specifies the direction of characters
    /// </summary>
    [OpenDocumentName("direction")]
    public TextDirection? Direction { get; set; } = null;

    /// <summary>
    /// specifies a vertical glyph orientation. The attribute specifies an angle or automatic mode. The only defined
    /// angle is 0 degrees, which disables this feature.
    ///
    /// Note: OpenDocument v1.1 did not support angle specifications that contain an angle unit
    /// identifier.Angle unit identifiers should be omitted for compatibility with OpenDocument v1.1.
    /// Value: auto, 0, 0deg, 0rad or 0grad.
    /// </summary>
    [OpenDocumentName("glyph-orientation-vertical")]
    public string? GlyphOrientationVertical { get; set; } = null;

    /// <summary>
    /// specifies if cell content is printed.
    /// </summary>
    [OpenDocumentName("print-content")]
    public OpenDocBoolean? PrintContent { get; set; } = null;

    /// <summary>
    /// specifies how the edge of the text in a cell is aligned after a rotation.
    /// </summary>
    [OpenDocumentName("rotation-align")]
    public RotationAlign? RotationAlign { get; set; } = null;

    /// <summary>
    /// specifies a shadow effect. The shadow effect is not applied to the text content of an element, but depending on the element
    /// where the attribute appears, to a paragraph, a text box, a page body, a header, a footer, a table or a table cell.
    /// </summary>
    [OpenDocumentName("shadow")]
    public string? Shadow { get; set; } = null;

    /// <summary>
    /// specifies whether content is reduced in size to fit within a cell or drawing object. Shrinking means that the font size
    /// of the content is decreased to fit the content into a cell or drawing object. The attribute has no effect on cells where the cell content
    /// already fits into the cell.
    /// </summary>
    [OpenDocumentName("shrink-to-fit")]
    public OpenDocBoolean? ShrinkToFit { get; set; } = null;

    /// <summary>
    /// The Writing Mode
    /// </summary>
    [OpenDocumentName("writing-mode")]
    public WritingMode? WritingMode { get; set; } = null;

    /// <summary>
    /// valid: wrap
    /// </summary>
    [OpenDocumentName("wrap-option", ElemNamespace = "fo")]
    public WrapOption? WrapOption { get; set; } = null;

    /// <summary>
    /// The background color
    /// </summary>
    [OpenDocumentName("background-color", ElemNamespace = "fo")]
    public Color? BackgroundColor { get; set; } = null;
}
