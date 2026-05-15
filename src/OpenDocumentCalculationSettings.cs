namespace OpenDocumentCreator;

/// <summary>
/// The table:calculation-settings element is a container for settings that affect the calculation of formula.
/// </summary>
/// <remarks>
/// Missing:
/// --------
/// Missing Attributes:
/// * table:null-year 19.674,
/// * table:precision-as-shown 19.692
///
/// Missing Elements:
/// * table:iteration 9.4.3
/// * table:null-date 9.4.2
/// </remarks>
public class OpenDocumentCalculationSettings : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "calculation-settings";

    /// <inheritdoc />
    internal override string? NamespaceName => "table";

    /// <summary>
    /// 19.590
    ///
    /// The table:case-sensitive attribute specifies whether to distinguish between upper and
    /// lower case when comparing, sorting or filtering content.
    ///
    /// That attribute is only evaluated if the operations take place on strings.
    ///
    /// The defined values for the table:case-sensitive attribute are:
    /// * false: upper and lower case are not distinguished when comparing, sorting or filtering content.
    /// * true: upper and lower case are distinguished when comparing, sorting or filtering content.
    ///
    /// For a table:calculation-settings 9.4.1 element the default value for this attribute is
    /// true.
    /// </summary>
    [OpenDocumentName("case-sensitive", ElemNamespace = "table")]
    public OpenDocBoolean? CaseSensitive { get; set; }

    /// <summary>
    /// 19.707
    ///
    /// The table:search-criteria-must-apply-to-whole-cell attribute specifies whether a
    /// search pattern matches the entire content of a cell.
    ///
    /// Note: The table:search-criteria-must-apply-to-whole-cell is used with the
    /// table:filter-condition element when the table:data-type attribute has the value
    /// text and the table:operator attribute has a value of: match, !match, =, or !=.
    ///
    /// The defined values for the table:search-criteria-must-apply-to-whole-cell are:
    /// * false: search pattern can match a substring at any position within a cell.
    /// * true: search pattern must match entire content of a cell.
    /// </summary>
    [OpenDocumentName("search-criteria-must-apply-to-whole-cell", ElemNamespace = "table")]
    public OpenDocBoolean? SearchCriteriaMustApplyToWholeCell { get; set; }

    /// <summary>
    /// 19.744
    ///
    /// The table:use-wildcards attribute specifies whether wildcards are enabled for character
    /// string comparisons and when searching.
    ///
    /// If enabled, in a query or search string of a function, the “?” (U+003F, QUESTION MARK), “*"
    /// (U+002A, ASTERISK), and “~" (U+007E, TILDE) are defined as:
    ///
    /// * "?" (U+003F, QUESTION MARK): matches any single character;
    /// * "*" (U+002A, ASTERISK): matches any sequence of characters, including an empty string;
    /// * "~" (U+007E, TILDE): escapes the special meaning of a QUESTION MARK, ASTERISK or
    /// TILDE character that follows immediately after the TILDE character.
    ///
    /// The table:use-regular-expressions attribute and the table:use-wildcards attribute
    /// are mutually exclusive.The attribute values cannot be true for both attributes.
    ///
    /// The defined values for the table:use-wildcards attribute are:
    ///     * false: wildcards are not enabled for character string comparisons and searching.
    ///     * true: wildcards are enabled for character string comparisons and searching.
    ///
    /// The default value for this attribute is false.
    /// </summary>
    [OpenDocumentName("use-wildcards", ElemNamespace = "table")]
    public OpenDocBoolean? UseWildcards { get; set; }

    /// <summary>
    /// 19.743
    /// The table:use-regular-expressions attribute specifies whether regular expressions are
    /// enabled for character string comparisons and when searching.
    ///
    /// Regular expressions are implementation-dependent expressions that, at a minimum, conform to
    /// the requirements of Conformance Clause C1 of[UTR18].
    ///
    /// The defined values for the table:use-regular-expressions attribute are:
    /// <list type="bullet">
    /// <item><term>false: regular expressions not enabled for string comparisons and searches.</term></item>
    /// <item><term>true: regular expressions enabled for string comparisons and searches.</term></item>
    /// </list>
    ///
    /// The default value for this attribute is true.
    /// </summary>
    [OpenDocumentName("use-regular-expressions", ElemNamespace = "table")]
    public OpenDocBoolean? UseRegularExpressions { get; set; }

    /// <summary>
    /// 19.585
    /// The table:automatic-find-labels attribute specifies whether a consumer should attempt
    /// to find labels of rows and columns.
    ///
    /// The defined values for the table:automatic-find-labels attribute are:
    /// <list type="bullet">
    /// <item><term>false: consumers should not attempt to find labels of rows and columns.</term></item>
    /// <item><term>true: consumers should attempt find labels of rows and columns.</term></item>
    /// </list>
    ///
    /// Note: The table:automatic-find-labels attribute enables the use of the automatic lookup
    /// of labels capability defined by OpenFormula.OpenFormula, 5.10.2. (* update*)
    ///
    /// The default value for this attribute is true.
    /// </summary>
    [OpenDocumentName("automatic-find-labels", ElemNamespace = "table")]
    public OpenDocBoolean? AutomaticFindLabels { get; set; }
}
