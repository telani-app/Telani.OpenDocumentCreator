using System.Xml;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The office:automatic-styles element contains automatic styles used in a document.
/// See also: 3.15.3
/// </summary>
/// <remarks>
/// An automatic style is one contains formatting properties that are considered to be properties of
/// the object to which the style is assigned.
///
/// Note: Common and automatic styles behave differently in OpenDocument editing consumers.
/// Common styles are presented to the user as a named set of formatting properties.The formatting
/// properties of an automatic style are presented to a user as properties of the object to which the
/// style is applied.
/// </remarks>
public class OpenDocumentAutomaticStyles : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "automatic-styles";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// This element represents the styles that specify the formatting properties of a page.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentPageLayout? PageLayout { get; set; } = null;

    /// <summary>
    /// This represents styles.
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentStyle> Styles { get; private set; } = [];
}
