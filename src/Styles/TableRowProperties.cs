namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:table-row-properties element specifies formatting properties for table rows.
/// </summary>
public class TableRowProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "table-row-properties";

    /// <summary>
    /// specifies a fixed row height.
    /// data type positiveLength
    /// </summary>
    [OpenDocumentName("row-height")]
    public Measurement? RowHeight { get; set; } = null;

    /// <summary>
    /// specifies that a row height should be recalculated automatically if content in the row changes
    /// 20.384
    /// </summary>
    [OpenDocumentName("use-optimal-row-height")]
    public OpenDocBoolean? UseOptimalRowHeight { get; set; } = null;

    /// <summary>
    /// transparent or a value of type color in \#rrggbb 18.3.9.
    /// 20.175
    /// </summary>
    [OpenDocumentName("background-color", ElemNamespace = "fo")]
    public Color? BackgroundColor { get; set; } = null;

    /// <summary>
    /// This attribute shall not be used at the same time as fo:break-after.
    /// </summary>
    [OpenDocumentName("break-before", ElemNamespace = "fo")]
    public BreakValue? BreakBefore { get; set; } = null;

    /// <summary>
    /// This attribute shall not be used at the same time as fo:break-before.
    /// </summary>
    [OpenDocumentName("break-after", ElemNamespace = "fo")]
    public BreakValue? BreakAfter { get; set; } = null;

    /// <summary>
    /// specifies a fixed minimum height for a row.
    /// data type nonNegativeLength
    /// 20.312
    /// </summary>
    [OpenDocumentName("min-row-height")]
    public Measurement? MinRowHeight { get; set; } = null;

    /// <summary>
    /// Valid Values: auto or always.
    /// 20.193
    /// </summary>
    [OpenDocumentName("keep-together", ElemNamespace = "fo")]
    public string? KeepTogether { get; set; } = null;

    /*
     * Missing Child-Elements:
        <style:background-image> 17.3.
        */
}
