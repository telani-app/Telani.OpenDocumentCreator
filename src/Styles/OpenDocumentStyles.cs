namespace OpenDocumentCreator.Styles;

/// <summary>
/// 3.15.2 office:styles
///
/// The office:styles element contains common styles used in a document. A common style is a
/// style chosen by a user for a document or portion thereof.
///
/// The office:styles element is usable within the following elements:
/// * office:document 3.1.2
/// * office:document-styles 3.1.3.3.
/// </summary>
internal class OpenDocumentStyles : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "styles";

    /// <inheritdoc />
    internal override string? NamespaceName => "office";

    /// <summary>
    /// number:number-style 16.27.2,
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentNumberStyle> NumberStyles { get; private set; } = [];

    /// <summary>
    /// style:style 16.2,
    /// </summary>
    [OpenDocumentName]
    public List<OpenDocumentStyle> Styles { get; private set; } = [];

    /*
     * The <office:styles> element has the following child elements:
     * <draw:fill-image> 16.40.6,
     * <draw:gradient> 16.40.1,
     * <draw:hatch> 16.40.5,
     * <draw:marker> 16.40.8,
     * <draw:opacity> 16.40.7,
     * <draw:stroke-dash> 16.40.9,
     * <number:boolean-style> 16.27.23,
     * <number:currency-style> 16.27.7,
     * <number:date-style> 16.27.10,
     * <number:percentage-style> 16.27.9,
     * <number:text-style> 16.27.25,
     * <number:time-style> 16.27.18,
     * <style:default-page-layout> 16.8,
     * <style:default-style> 16.4,
     * <style:presentation-page-layout> 16.41,
     * <svg:linearGradient> 16.40.2,
     * <svg:radialGradient> 16.40.3,
     * <table:table-template> 16.18,
     * <text:bibliography-configuration> 16.29.6,
     * <text:linenumbering-configuration> 16.29.1,
     * <text:list-style> 16.30,
     * <text:notes-configuration> 16.29.3 and
     * <text:outline-style> 16.34.
     */
}
