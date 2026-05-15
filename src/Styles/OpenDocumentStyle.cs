namespace OpenDocumentCreator.Styles;

/// <summary>
/// A style defines the visual rendering of most open document elements.
/// </summary>
public class OpenDocumentStyle : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "style";

    /// <summary>
    /// The name of the style.
    /// </summary>
    [OpenDocumentName("name")]
    public string? Name { get; set; } = null;

    /// <summary>
    /// What kind of style is this?
    /// </summary>
    [OpenDocumentName("family")]
    public StyleFamily? Family { get; set; } = null;

    /// <summary>
    /// A parent style that defines inheritance.
    /// </summary>
    [OpenDocumentName("parent-style-name")]
    public string? ParentStyleName { get; set; } = null;

    /// <summary>
    /// The name of the data style.
    /// </summary>
    [OpenDocumentName("data-style-name")]
    public string? DataStyleName { get; set; }

    /// <summary>
    /// The name of the master or template page.
    /// </summary>
    [OpenDocumentName("master-page-name")]
    public string? MasterPageName { get; set; } = null;

    /// <summary>
    ///  Table properties that define how a table is rendered. This is useful together with <see cref="StyleFamily.Table"/>.
    /// </summary>
    [OpenDocumentName]
    public TableProperties? TableProperties { get; set; } = null;

    /// <summary>
    /// Table row properties define properties for a row, useful with <see cref="StyleFamily.TableRow"/>
    /// </summary>
    [OpenDocumentName]
    public TableRowProperties? TableRowProperties { get; set; } = null;

    /// <summary>
    /// Table column properties define properties for a column, useful with <see cref="StyleFamily.TableColumn"/>
    /// </summary>
    [OpenDocumentName]
    public TableColumnProperties? TableColumnProperties { get; set; } = null;

    /// <summary>
    /// Table cell properties define details about how cells are presented, useful with <see cref="StyleFamily.TableCell"/>
    /// </summary>
    [OpenDocumentName]
    public TableCellProperties? TableCellProperties { get; set; }

    /// <summary>
    /// Paragraph properties define how paragraphs are formatted and rendered.
    /// </summary>
    [OpenDocumentName]
    public ParagraphProperties? ParagraphProperties { get; set; } = null;

    /// <summary>
    /// Text properties define how text is rendered.
    /// </summary>
    [OpenDocumentName]
    public TextProperties? TextProperties { get; set; } = null;

    /// <summary>
    ///      style:graphic-properties 17.21, useful with <see cref="StyleFamily.Graphic"/>
    /// </summary>
    [OpenDocumentName]
    public GraphicProperties? GraphicProperties { get; set; } = null;

    /*
     * Missing:
     *
     * Attributes:
     * style:auto-update 19.463,
     * style:class 19.466,
     * style:default-outlinelevel 19.470,
     * style:display-name 19.472,
     * style:list-level 19.495,
     * style:list-style-name 19.496,
     * style:next-style-name 19.499.3,
     * style:percentage-data-style-name 19.507.
     *
     * Child-Elements:
     * <style:chart-properties>17.22,
     * <style:drawing-page-properties> 17.25,

     * <style:map> 16.3,
     * <style:rubyproperties>17.10,
     * <style:section-properties> 17.11
    */
}
