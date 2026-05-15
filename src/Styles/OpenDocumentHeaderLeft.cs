namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:header-left element represents the content for a header for a left page, if
/// different from the right page in a style:master-page element.
/// </summary>
public class OpenDocumentHeaderLeft : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "header-left";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// The style:display attribute specifies whether the header or footer is displayed or not.
    /// </summary>
    /// <remarks>
    /// The defined values for the style:display attribute are:
    ///
    /// * false: header or footer is not displayed.
    /// * true: header or footer is displayed.
    ///
    /// The default value for this attribute is true.
    /// </remarks>
    [OpenDocumentName("display", ElemNamespace = "style")]
    public string? Display { get; set; }
}
