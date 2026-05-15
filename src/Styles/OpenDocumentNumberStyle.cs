using System;
using System.Diagnostics.Metrics;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// This element is a container for elements that define a style for decimal numbers.
///
/// From: 16.27.2
///
/// Usable in automatic:styles and office:styles
/// </summary>
public class OpenDocumentNumberStyle : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "number-style";

    /// <inheritdoc />
    internal override string? NamespaceName => "number";

    /// <summary>
    /// The name of the style
    /// </summary>
    [OpenDocumentName("name", ElemNamespace = "style")]
    public string? Name { get; set; } = null;

    /// <summary>
    /// The number element specifies the display formatting properties for a decimal number.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentNumber? Number { get; set; } = null;

    /// <summary>
    /// The number:country attribute specifies a country code for a data style. The country code is
    /// used for formatting properties whose evaluation is locale dependent.
    /// </summary>
    /// <remarks>
    /// If a country is not specified, the system settings are used.
    /// </remarks>
    [OpenDocumentName("country", ElemNamespace = "number")]
    public string? Country { get; set; } = null;

    /// <summary>
    /// The number:language attribute specifies a language code. The country code is used for
    /// formatting properties whose evaluation is locale dependent.
    /// </summary>
    /// <remarks>
    /// If a language code is not specified, either the system settings or the setting for the system's
    /// language are used, depending on the property whose value should be evaluated.
    /// </remarks>
    [OpenDocumentName("language", ElemNamespace = "number")]
    public string? Language { get; set; } = null;

    /// <summary>
    /// The number:rfc-language-tag attribute specifies a language identifier according to the rules
    /// of [RFC5646], or its successors.
    ///
    /// It shall only be used if its value can not be expressed as a valid combination of the
    /// number:language, number:script and number:country attributes.
    /// </summary>
    [OpenDocumentName("rfc-language-tag", ElemNamespace = "number")]
    public string? RfcLanguageTag { get; set; } = null;

    /// <summary>
    /// The number:script attribute specifies a script code. The script code is used for formatting
    /// properties whose evaluation is locale dependent. The attribute should be used only if necessary
    /// according to the rules of §2.2.3 of [RFC5646], or its successors.
    /// </summary>
    [OpenDocumentName("script", ElemNamespace = "number")]
    public string? Script { get; set; } = null;

    /// <summary>
    /// The number:title attribute specifies the title of a data style.
    /// </summary>
    /// <remarks>
    /// The number:title attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("title", ElemNamespace = "number")]
    public string? Title { get; set; } = null;

    /// <summary>
    /// The number:transliteration-country attribute specifies a country code in conformance
    /// with[RFC5646].
    /// </summary>
    /// <remarks>
    /// If no language/country(locale) combination is specified the locale of the data style is used.
    ///
    /// The number:transliteration-country attribute has the data type countryCode 18.3.11.
    /// </remarks>
    [OpenDocumentName("transliteration-country", ElemNamespace = "number")]
    public string? TransliterationCountry { get; set; } = null;

    /// <summary>
    /// The number:transliteration-format attribute specifies which number characters to use.
    /// </summary>
    /// <remarks>
    /// The value of the number:transliteration-format attribute shall be a decimal "DIGIT ONE"
    /// character with numeric value 1 as listed in the Unicode Character Database file UnicodeData.txt
    /// with value 'Nd' (Numeric decimal digit) in the General_Category/Numeric_Type property field 6
    /// and value '1' in the Numeric_Value fields 7 and 8, respectively as listed in
    /// DerivedNumericValues.txt
    ///
    /// If no format is specified the default ASCII representation of Latin-Indic digits is used, other
    /// transliteration attributes present in that case are ignored.
    ///
    /// The default value for this attribute is 1.
    ///
    /// The number:transliteration-format attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("transliteration-format", ElemNamespace = "number")]
    public string? TransliterationFormat { get; set; } = null;

    /// <summary>
    /// The number:transliteration-language attribute specifies a language code in
    /// conformance with [RFC5646].
    /// </summary>
    /// <remarks>
    /// If no language/country (locale) combination is specified the locale of the data style is used.
    ///
    /// The number:transliteration-language attribute has the data type countryCode
    /// 18.3.11.
    /// </remarks>
    [OpenDocumentName("transliteration-language", ElemNamespace = "number")]
    public string? TransliterationLanguage { get; set; } = null;

    /// <summary>
    /// The number:transliteration-style attribute specifies the transliteration-format of a
    /// number system.
    /// </summary>
    /// <remarks>
    /// The semantics of the values of the number:transliteration-style attribute are locale and
    /// implementation-dependent.
    ///
    /// The default value for this attribute is short.
    ///
    /// The values of the number:transliteration-style attribute are short, medium or long.
    /// </remarks>
    [OpenDocumentName("transliteration-style", ElemNamespace = "number")]
    public string? TransliterationStyle { get; set; } = null;

    /// <summary>
    /// The style:display-name attribute specifies the name of a style as it should appear in the user
    /// interface. If this attribute is not present, the display name is the same as the style name.
    /// </summary>
    /// <remarks>
    /// The style:display-name attribute has the data type string 18.2.
    /// </remarks>
    [OpenDocumentName("display-name", ElemNamespace = "style")]
    public string? DisplayName { get; set; } = null;

    /// <summary>
    /// The style:volatile attribute specifies whether unused style in a document are retained or
    /// discarded by consumers.
    /// </summary>
    /// <remarks>
    /// The defined values for the style:volatile attribute are:
    /// * false: consumers should discard the unused styles.
    /// * true: consumers should keep unused styles.
    /// </remarks>
    [OpenDocumentName("volatile", ElemNamespace = "style")]
    public string? Volatile { get; set; } = null;

    /// <summary>
    /// 16.27.6: This specifies the display formatting properties for a number style
    /// that should be displayed as a fraction.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentFraction? Fraction { get; set; } = null;

    // Element
    // <summary>
    // 16.27.5
    // </summary>
    // [OpenDocumentName("scientific-number", ElemNamespace = "number")]
    // public string ScientificNumber { get; set; } = null;

    // Element
    // <summary>
    // 16.27.26
    // </summary>
    // [OpenDocumentName("text", ElemNamespace = "number")]
    // public string Text { get; set; } = null;

    // Element
    // <summary>
    // 16.3
    // </summary>
    // [OpenDocumentName("map", ElemNamespace = "style")]
    // public string Map { get; set; } = null;

    /// <summary>
    /// 16.27.28: This element specifies formatting properties for text.
    /// </summary>
    [OpenDocumentName("text-properties", ElemNamespace = "style")]
    public TextProperties? TextProperties { get; set; } = null;
}
