namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:font-face element represents a font face declaration which documents the properties of a font used in a document.
///
/// OpenDocument font face declarations directly correspond to the @font-face font description of[CSS2] (see §15.3.1)
///  and the font-face element of [SVG] (see §20.8.3).
///
/// OpenDocument font face declarations may have an unique name.This name can be used inside styles(as an attribute
/// of style:text-properties element) as value of the style:font- name attribute to select a font face declaration.If a font face
/// declaration is referenced by name, the font matching algorithms for selecting a font declaration based on the font-family, font-style,
///  font-variant, font-weight and font-size descriptors are not used but the referenced font face declaration
/// is used directly. (See §15.5 [CSS2])
///
/// Consumers should implement the CSS2 font matching algorithm with the OpenDocument font face extensions.They may implement variations
/// of the CSS2 font matching algorithm.They may implement a font matching based only on the font face declarations, that is, a font
/// matching that is not applied to every character independently but only once for each font face declaration. (See §15.5 [CSS2])
///
/// Font face declarations support the font descriptor attributes and elements described in §20.8.3 of[SVG].
///
/// The style:font-face element is usable within the following element: office:font-face-decls 3.14.
/// </summary>
internal class OpenDocumentFontFace : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "font-face";

    /// <inheritdoc />
    internal override string? NamespaceName => "style";

    /// <summary>
    /// style:name 19.498.3
    /// </summary>
    [OpenDocumentName("name", ElemNamespace = "style")]
    public string? Name { get; set; } = null;

    /// <summary>
    /// svg:font-family 19.528
    /// </summary>
    [OpenDocumentName("font-family", ElemNamespace = "svg")]
    public string? FontFamily { get; set; } = null;

    /*
     * The <style:font-face> element has the following attributes:
     * style:font-adornments 19.478,
     * style:font-charset 19.479,
     * style:font-family-generic 19.480,
     * style:font-pitch 19.481,
     * svg:accent-height 19.519,
     * svg:alphabetic 19.520,
     * svg:ascent 19.521,
     * svg:bbox 19.522,
     * svg:cap-height 19.523,
     * svg:descent 19.527,
     * svg:font-size 19.529,
     * svg:font- stretch 19.530,
     * svg:font-style 19.531,
     * svg:font-variant 19.532,
     * svg:font-weight 19.533,
     * svg:hanging 19.538,
     * svg:ideographic 19.540,
     * svg:mathematical 19.541,
     * svg:overline-position 19.545,
     * svg:overline-thickness 19.546,
     * svg:panose-1 19.547,
     * svg:slope 19.552,
     * svg:stemh 19.554,
     * svg:stemv 19.555,
     * svg:strikethrough-position 19.558,
     * svg:strikethrough-thickness 19.559,
     * svg:underline-position 19.562,
     * svg:underline-thickness 19.563,
     * svg:unicode-range 19.564,
     * svg:units- per-em 19.565,
     * svg:v-alphabetic 19.566,
     * svg:v-hanging 19.567,
     * svg:v-ideographic 19.568,
     * svg:v-mathematical 19.569,
     * svg:widths 19.572 and
     * svg:x-height 19.576.
     *
     * The <style:font-face> element has the following child elements:
     * <svg:definition-src> 16.25 and
     * <svg:font-face-src> 16.22.
     */
}
