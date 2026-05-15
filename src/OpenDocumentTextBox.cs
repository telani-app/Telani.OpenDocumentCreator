namespace OpenDocumentCreator;

/// <summary>
/// 10.4.3 draw:text-box
///
/// A text box that lives outside of the flow of the document.
///
/// The draw:text-box element represents a text box. This element may be used to place text
/// in a container that is outside of the flow of the document.
/// </summary>
/// <remarks>
/// Missing:
/// ---------
///
/// The draw:text-box element has the following attributes:
/// * draw:chain-next-name 19.118,
/// * draw:corner-radius 19.127,
/// * fo:max-height 19.238,
/// * fo:max-width 19.239
/// * fo:min-height 19.240,
/// * fo:min-width 19.241,
/// * text:id 19.809.2
/// * xml:id 19.914
///
/// The draw:text-box element has the following child elements:
/// * dr3d:scene 10.5.2
/// * draw:a 10.4.12,
/// * draw:caption 10.3.11,
/// * draw:circle 10.3.8,
/// * draw:connector 10.3.10,
/// * draw:control 10.3.13,
/// * draw:custom-shape 10.6.1,
/// * draw:ellipse 10.3.9,
/// * draw:frame 10.4.2,
/// * draw:g 10.3.15,
/// * draw:line 10.3.3,
/// * draw:measure 10.3.12,
/// * draw:page-thumbnail 10.3.14,
/// * draw:path 10.3.7,
/// * draw:polygon 10.3.5
/// * draw:polyline 10.3.4,
/// * draw:rect 10.3.2,
/// * draw:regular-polygon 10.3.6
/// * table:table 9.1.2,
/// * text:alphabetical-index 8.8,
/// * text:bibliography 8.9
/// * text:change 5.5.7.4,
/// * text:change-end 5.5.7.3,
/// * text:change-start 5.5.7.2
/// * text:h 5.1.2,
/// * text:illustration-index 8.4,
/// * text:list 5.3.1
/// * text:numbered-paragraph 5.3.6,
/// * text:object-index 8.6
/// </remarks>
public class OpenDocumentTextBox : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "text-box";

    /// <inheritdoc />
    internal override string? NamespaceName => "draw";

    /// <summary>
    /// text:p 5.1.3,
    ///
    /// The content of the text box in paragraphs.
    /// </summary>
    [OpenDocumentName]
    public IList<OpenDocumentParagraph> Paragraphs { get; } = [];
}