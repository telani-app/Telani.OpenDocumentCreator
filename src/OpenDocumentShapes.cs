using System.Xml.Linq;

namespace OpenDocumentCreator;

/// <summary>
/// The table:shapes element contains all the elements that represent graphic shapes that are
/// anchored on a table where this element occurs.
///
/// See: 9.2.8
/// </summary>
/// <remarks>
/// This element can have many more types, however we currently only have Frame implemented.
/// </remarks>
public class OpenDocumentShapes : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "shapes";

    /// <inheritdoc />
    internal override string? NamespaceName => "table";

    /// <summary>
    /// The draw:frame element represents a frame and serves as the container for elements that
    /// may occur in a frame.
    /// </summary>
    [OpenDocumentName]
    public IList<OpenDocumentFrame> Frames { get; } = [];
}
