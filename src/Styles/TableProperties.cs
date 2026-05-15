namespace OpenDocumentCreator.Styles;

/// <summary>
/// Properties that influence how a table is rendered.
/// </summary>
public class TableProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "table-properties";

    /// <summary>
    /// style:writing-mode 20.394.7,
    /// </summary>
    [OpenDocumentName("writing-mode")]
    public WritingMode? WritingMode { get; set; }

    /// <summary>
    /// table:display 20.406.
    /// </summary>
    [OpenDocumentName("display", ElemNamespace = "table")]
    public OpenDocBoolean? Display { get; set; }
    /*
     * Missing:
     * Attribute:
     * fo:background-color 20.175,
     * fo:break-after 20.177,
     * fo:break-before 20.178,
     * fo:keep-with-next 20.194,
     * fo:margin 20.198,
     * fo:margin-bottom 20.199,
     * fo:margin-left 20.200,
     * fo:margin-right 20.201,
     * fo:margin-top 20.202,
     * style:may-break-between-rows 20.311,
     * style:page-number 20.320,
     * style:rel-width 20.332.2,
     * style:shadow 20.349,
     * style:width 20.389,
     * style:writing-mode 20.394.7,
     * table:align 20.404,
     * table:border-model 20.405
     * table:display 20.406.
     *
     * Child Elements
     * <style:background-image> 17.3.
    */
}
