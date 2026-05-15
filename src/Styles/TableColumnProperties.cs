namespace OpenDocumentCreator.Styles;

/// <summary>
/// Properties to style a Column.
///
/// Enables deduplication by implementing value-based equality.
/// </summary>
public class TableColumnProperties : OpenDocumentWritable, IEquatable<TableColumnProperties>
{
    /// <inheritdoc/>
    internal override string OpenDocumentElementName => "table-column-properties";

    /// <summary>
    /// specifies a fixed width for a column.
    /// DataTyp: positiveLength
    /// </summary>
    [OpenDocumentName("column-width")]
    public Measurement? ColumnWidth { get; set; } = null;

    /// <summary>
    /// specifies that a column width should be recalculated automatically if content in the column changes.
    /// </summary>
    [OpenDocumentName("use-optimal-column-width")]
    public OpenDocBoolean? UseOptimalColumnWidth { get; set; } = null;

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
    /// specifies a relative width of a column with a number value, followed by a ”*” (U+002A, ASTERISK) character.
    /// If rc is the relative with of the column, rs the sum of all relative columns widths, and ws the absolute
    /// width that is available for these columns the absolute width wc of the column is wc=rcws/rs.
    /// </summary>
    [OpenDocumentName("rel-column-width")]
    public string? RelativeColumnWidth { get; set; } = null;

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return Equals(obj as TableColumnProperties);
    }

    /// <summary>
    /// Equals?
    /// </summary>
    /// <param name="other">other</param>
    /// <returns>True if <paramref name="other"/> is equal to this element, false otherwise.</returns>
    public bool Equals(TableColumnProperties? other)
    {
        return other is not null &&
               EqualityComparer<Measurement?>.Default.Equals(ColumnWidth, other.ColumnWidth) &&
               UseOptimalColumnWidth == other.UseOptimalColumnWidth &&
               BreakBefore == other.BreakBefore &&
               BreakAfter == other.BreakAfter &&
               RelativeColumnWidth == other.RelativeColumnWidth;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(ColumnWidth, UseOptimalColumnWidth, BreakBefore, BreakAfter, RelativeColumnWidth);

    /// <summary>
    /// Compare two TableColumnProperties
    /// </summary>
    /// <param name="left">left</param>
    /// <param name="right">right</param>
    /// <returns>Are equal?</returns>
    public static bool operator ==(TableColumnProperties left, TableColumnProperties right) => EqualityComparer<TableColumnProperties>.Default.Equals(left, right);

    /// <summary>
    ///  unequal operator
    /// </summary>
    /// <param name="left">left</param>
    /// <param name="right">right</param>
    /// <returns>unequal?</returns>
    public static bool operator !=(TableColumnProperties left, TableColumnProperties right) => !(left == right);
}
