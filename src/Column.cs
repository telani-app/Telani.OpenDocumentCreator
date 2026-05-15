namespace OpenDocumentCreator;

/// <summary>
/// A Column in an OpenDocumentTable.
///
/// The table:table-column element specifies properties for one
/// or more adjacent columns in a table.
///
/// Columns do not contain any content. They only apply style to that column (=define a width).
/// </summary>
/// <remarks>
/// Missing:
/// --------
/// * xml:id 19.914.
/// </remarks>
public class Column : OpenDocumentWritable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class.
    /// </summary>
    public Column()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class and that sets a style by name at the same time.
    /// </summary>
    /// <param name="styleName"></param>
    public Column(string styleName) => StyleName = styleName;

    /// <summary>
    /// The column style name, make sure this style exists
    /// and is a StyleFamily.TableColumn style.
    ///
    /// The table:style-name attribute specifies a style:style element of type table-column
    /// </summary>
    [OpenDocumentName("style-name", ElemNamespace = "table")]
    public string? StyleName { get; set; }

    /// <summary>
    /// 19.615 table:default-cell-style-name
    ///
    /// The table:default-cell-style-name attribute specifies a default cell style.
    /// Cells defined by a table:table-cell element that do not have a table:style-name
    /// attribute value use the specified default cell style.
    ///
    /// If an individual cell has a default style specified by a table:default-cell-style-name
    /// attribute on a table:table-column element and by a style:default-cell-style-name on a
    /// table:table-row element, the default style specified by the table:table-row element
    /// shall be applied to the cell and the default style specified by the
    /// table:table-column element shall be ignored.
    /// </summary>
    [OpenDocumentName("default-cell-style-name", ElemNamespace = "table")]
    public string DefaultCellStyleName { get; set; } = "ce1";

    /// <summary>
    /// 19.615 table:default-cell-style-name
    ///
    /// The table:number-columns-repeated attribute specifies the number of columns to which a
    /// column description applies. If two or more columns are adjoining, and have the same style, this
    /// attribute may be used to describe them with a single table:table-column element.
    ///
    /// For a table:table-column 9.1.6 element the default value for this attribute is 1.
    /// </summary>
    [OpenDocumentName("number-columns-repeated", ElemNamespace = "table")]
    public string NumberColumnsRepeated { get; set; } = "1";

    /// <summary>
    /// table:visibility 19.749
    ///
    /// The table:visibility attribute specifies whether a row or column is visible.,
    /// The default value for this attribute is visible.
    /// </summary>
    [OpenDocumentName("visibility", ElemNamespace = "table")]
    public Visibility Visibility { get; set; }

    /// <inheritdoc />
    internal override string OpenDocumentElementName => "table-column";

    /// <inheritdoc />
    internal override string? NamespaceName => "table";
}
