using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The office:master-styles element contains master styles that are used in a document. A
/// master style contains formatting and other content that is displayed with document content when
/// the style is used.
/// </summary>
public class OpenDocumentMasterStyles : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "master-styles";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// This element contains the content of headers and footers.
    /// </summary>
    [OpenDocumentName]
    public OpenDocumentMasterPage? MasterPage { get; set; }
}
