namespace OpenDocumentCreator;

/// <summary>
/// The number:number-style element is a container for elements that define a style for
/// decimal numbers.
/// </summary>
public class OpenDocumentNumber : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "number";

    /// <inheritdoc />
    internal override string? NamespaceName => "number";

    /// <summary>
    /// number:min-integer-digits 19.352, datatype integer
    /// </summary>
    [OpenDocumentName("min-integer-digits", ElemNamespace = "number")]
    public string? MinIntegerDigits { get; set; } = null;

    /*
     *
     * Missing Attributes:
     * number:decimal-places (19.343.2)
     * number:decimal-replacement (19.344)
     * number:display-factor (19.346)
     * number:grouping (10.348)
     *
     * Child Element:
     * number:embedded-text (16.27.4)
     *
     */
}
