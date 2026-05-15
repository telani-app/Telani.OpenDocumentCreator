using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The number:fraction element specifies the display formatting properties for a number style
/// that should be displayed as a fraction.
///
/// See: 16.27.6
/// </summary>
public class OpenDocumentFraction : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "fraction";

    /// <inheritdoc />
    internal override string? NamespaceName => "number";

    /// <summary>
    /// The number:denominator-value attribute specifies an integer value that is used as
    /// denominator of a fraction. If this attribute is not present, a denominator that is appropriate for
    /// displaying the number is used.
    /// </summary>
    [OpenDocumentName("denominator-value", ElemNamespace = "number")]
    public string? DenominatorValue { get; set; } = null;

    /// <summary>
    /// The number:grouping attribute specifies whether the integer digits of a number should be
    /// grouped using a separator character.
    /// </summary>
    /// <remarks>
    /// The grouping character that is used and the number of digits that are grouped together depends
    /// on the language and country of the style.
    ///
    /// The defined values for the number:grouping attribute are:
    ///
    /// * false: integer digits of a number are note grouped using a separator character.
    /// * true: integer digits of a number should be grouped by a separator character.
    ///
    /// The number:grouping attribute has the data type boolean 18.3.3.
    ///
    /// The default value for this attribute is false.
    /// </remarks>
    [OpenDocumentName("grouping", ElemNamespace = "number")]
    public string? Grouping { get; set; } = null;

    /// <summary>
    /// The number:min-denominator-digits attribute specifies the minimum number of digits to
    /// use to display the denominator of a fraction.
    /// </summary>
    /// <remarks>
    /// The number:min-denominator-digits attribute has the data type integer 18.2
    /// </remarks>
    [OpenDocumentName("min-denominator-digits", ElemNamespace = "number")]
    public string? MinDenominatorDigits { get; set; } = null;

    /// <summary>
    /// The number:min-integer-digits attribute specifies the minimum number of integer digits to
    /// display in a number, a scientific number, or a fraction.
    /// </summary>
    /// <remarks>
    /// For a number:fraction element, if the number:min-integer-digits attribute is not
    /// present, no integer portion is displayed.
    ///
    /// The number:min-integer-digits attribute has the data type integer 18.2.
    /// </remarks>
    [OpenDocumentName("min-integer-digits", ElemNamespace = "number")]
    public string? MinIntegerDigits { get; set; } = null;

    /// <summary>
    /// The number:min-numerator-digits attribute specifies the minimum number of digits to use
    /// to display the numerator in a fraction.
    /// </summary>
    /// <remarks>
    /// The number:min-numerator-digits attribute has the data type integer 18.2.
    /// </remarks>
    [OpenDocumentName("min-numerator-digits", ElemNamespace = "number")]
    public string? MinNumeratorDigits { get; set; } = null;
}
