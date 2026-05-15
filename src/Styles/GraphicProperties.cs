using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace OpenDocumentCreator.Styles;

/// <summary>
/// The style:graphic-properties element specifies formatting properties for chart, draw,
/// graphic, and frame elements.
/// </summary>
public class GraphicProperties : OpenDocumentWritable
{
    /// <inheritdoc />
    internal override string OpenDocumentElementName => "graphic-properties";

    /// <summary>
    /// The draw:fill attribute specifies the fill style for a graphic object. Graphic objects that are not
    /// closed will not be filled.
    /// </summary>
    /// <remarks>
    /// Note: A path without a closepath at the end is open and will not be filled.
    ///
    /// The defined values for the draw:fill attribute are:
    ///
    /// * bitmap: the drawing object is filled with the bitmap specified by the draw:fill-imagename
    /// attribute.
    /// * gradient: the drawing object is filled with the gradient specified by the draw:fillgradient-
    /// name attribute.
    /// * hatch: the drawing object is filled with the hatch specified by the draw:fill-hatch-name
    /// attribute.
    /// * none: the drawing object is not filled.
    /// * solid: the drawing object is filled with the color specified by the draw:fill-color
    /// attribute.
    ///
    /// The values of the draw:fill attribute are none, solid, bitmap, gradient or hatch.
    /// </remarks>
    [OpenDocumentName("fill", ElemNamespace = "draw")]
    public FillValue? Fill { get; set; } = FillValue.None;

    /// <summary>
    /// The draw:fill-color attribute specifies the color of the fill for a graphic object. It is used only
    /// if the draw:fill attribute has one of the values solid or hatch.
    /// </summary>
    [OpenDocumentName("fill-color", ElemNamespace = "draw")]
    public Color? FillColor { get; set; }

    /// <summary>
    /// The draw:opacity attribute specifies the opacity for an image or graphic object. The value is a
    /// percentage, where 0% is fully transparent and 100% is fully opaque.
    /// </summary>
    /// <remarks>
    /// The defined value range for the draw:opacity attribute is 0% to 100%, inclusive.
    /// Use of the draw:opacity attribute disables any transparency effect and set the opacity for the
    /// fill area of a graphic object.
    /// </remarks>
    [OpenDocumentName("opacity", ElemNamespace = "draw")]
    public string? Opacity { get; set; }

    /// <summary>
    /// The draw:stroke attribute specifies the style of the stroke on the current object.
    /// </summary>
    [OpenDocumentName("stroke", ElemNamespace = "draw")]
    public StrokeValue Stroke { get; set; } = StrokeValue.None;

    /// <summary>
    /// The svg:stroke-width attribute specifies the width of a stroke.
    /// </summary>
    [OpenDocumentName("stroke-width", ElemNamespace = "svg")]
    public Measurement? StrokeWidth { get; set; } = new Measurement(0m, Unit.MM);

    /// <summary>
    /// The svg:stroke-color attribute specifies the color of a stroke.
    /// </summary>
    [OpenDocumentName("stroke-color", ElemNamespace = "svg")]
    public Color? StrokeColor { get; set; }

    /// <summary>
    /// The svg:stroke-opacity attribute specifies the opacity of a stroke. The value of this attribute
    /// can be a number between 0 (fully transparent) and 1 (fully opaque) or a percentage value in the
    /// range 0% to 100%.
    /// </summary>
    /// <remarks>
    /// The values of the svg:stroke-opacity attribute are a value of type double 18.2 in the range
    /// [0,1] or a value of type zeroToHundredPercent 18.3.41.
    /// </remarks>
    [OpenDocumentName("stroke-opacity", ElemNamespace = "svg")]
    public string? StrokeOpacity { get; set; }

    /// <summary>
    /// The draw:stroke-linejoin attribute specifies the shape at the corners of paths or other
    /// vector shapes when they are stroked.
    /// </summary>
    /// <remarks>
    /// The defined values for the draw:stroke-linejoin attribute are:
    /// * bevel: See §11.4 of[SVG].
    /// * middle: mean value between joins is used(deprecated)
    /// * miter: See §11.4 of[SVG].
    /// * none: no shape specified.
    /// * round: See §11.4 of[SVG].
    /// </remarks>
    [OpenDocumentName("stroke-linejoin", ElemNamespace = "draw")]
    public string? StrokeLineJoin { get; set; }

    /// <summary>
    /// The svg:stroke-linecap attribute specifies the shape of the end of open subpaths when they
    /// are stroked.
    /// </summary>
    /// <remarks>
    /// The defined values for the svg:stroke-linecap attribute are:
    /// * butt: See §11.4 of[SVG].
    /// * round: See §11.4 of[SVG].
    /// * square: See §11.4 of[SVG].
    /// </remarks>
    [OpenDocumentName("stroke-linecap", ElemNamespace = "svg")]
    public string? StrokeLineCap { get; set; }

    /// <summary>
    /// The draw:textarea-horizontal-align attribute specifies the horizontal alignment of the
    /// text area inside a shape.
    /// </summary>
    /// <remarks>
    /// The defined values for the draw:textarea-horizontal-align attribute are:
    /// * center: text area is centered horizontally inside a shape.
    /// * justify: text area is justified horizontally inside a shape.
    /// * left: text area is left aligned horizontally inside a shape.
    /// * right: text area is right aligned horizontally inside a shape.
    ///
    /// The values of the draw:textarea-horizontal-align attribute are left, center, right
    /// or justify.
    /// </remarks>
    [OpenDocumentName("textarea-horizontal-align", ElemNamespace = "draw")]
    public string? TextareaHorizontalAlign { get; set; }

    /// <summary>
    /// The draw:textarea-horizontal-align attribute specifies the horizontal alignment of the
    /// text area inside a shape.
    /// </summary>
    /// <remarks>
    /// The defined values for the draw:textarea-horizontal-align attribute are:
    /// * center: text area is centered horizontally inside a shape.
    /// * justify: text area is justified horizontally inside a shape.
    /// * left: text area is left aligned horizontally inside a shape.
    /// * right: text area is right aligned horizontally inside a shape.
    /// </remarks>
    [OpenDocumentName("textarea-vertical-align", ElemNamespace = "draw")]
    public string? TextareaVerticalAlign { get; set; }

    /// <summary>
    /// The draw:auto-grow-height attributes specifies whether to automatically increase the height
    /// of the drawing object if text is added to the drawing object. This attribute is evaluated only for text
    /// boxes.
    /// </summary>
    /// <remarks>
    /// If both draw:auto-grow-width and draw:auto-grow-height are present, a consumer
    /// should first grow the size of the drawing object in the dimension of the major text flow(width for
    /// horizontal writing, and height for vertical writing). Only after that size component is filled, a
    /// consumer should adjust the other dimension to fit the text content.
    ///
    /// The defined values for the draw:auto-grow-height attribute are:
    ///
    /// * false: height of a drawing object should not automatically increase if text is added to the drawing object.
    /// * true: height of a drawing object should automatically increase if text is added to the drawing object.
    /// </remarks>
    [OpenDocumentName("auto-grow-height", ElemNamespace = "draw")]
    public string? AutoGrowHeight { get; set; }

    /// <summary>
    /// The style:mirror attribute specifies whether an image is mirrored before it is displayed. The
    /// mirroring can be vertical or horizontal or both.
    /// </summary>
    /// <remarks>
    /// The defined values for the style:mirror attribute are:
    ///
    /// * none: image should not be mirrored before being displayed.
    /// * horizontal: image should be mirrored horizontally before being displayed.
    /// * horizontal-on-even: image should be mirrored horizontally on even numbered pages
    /// before being displayed.
    /// * horizontal-on-odd: image should be mirrored horizontally on odd numbered pages
    /// before being displayed.
    /// * vertical: image should be mirrored vertically before being displayed.
    ///
    /// The value vertical and the horizontal values can be specified together, separated by a white
    /// space.
    ///
    /// The values of the style:mirror attribute are none, vertical, or two white space separated
    /// values, that may appear in any order.One of these values is always vertical. The other value
    /// is one of: horizontal, horizontal-on-odd or horizontal-on-even.
    /// </remarks>
    [OpenDocumentName("mirror", ElemNamespace = "style")]
    public string? Mirror { get; set; }

    /// <summary>
    /// The draw:image-opacity attribute specifies the opacity of an image.
    /// </summary>
    /// <remarks>
    /// The draw:image-opacity attribute has the data type zeroToHundredPercent 18.3.41.
    /// </remarks>
    [OpenDocumentName("image-opacity", ElemNamespace = "draw")]
    public string? ImageOpacity { get; set; }

    /// <summary>
    /// See §7.20.1 of [XSL].
    ///
    /// In the OpenDocument XSL compatible namespace, the fo:clip attribute does not support em
    /// and px values.
    ///
    /// The defined value for the fo:clip attribute is a value of type clipShape 18.3.8.
    ///
    /// The values of the fo:clip attribute are auto or a value of type clipShape 18.3.8.
    /// </summary>
    [OpenDocumentName("clip", ElemNamespace = "fo")]
    public string? Clip { get; set; }

    /// <summary>
    /// The draw:red attribute specifies together with the attributes draw:blue and draw:green a
    /// non destructive filter for a linear transformation of the white balance of a pixel image. See 20.94.
    /// </summary>
    /// <remarks>
    /// The draw:red attribute specifies the offset for the red color channel.
    ///
    /// The draw:red attribute has the data type signedZeroToHundredPercent 18.3.30.
    /// </remarks>
    [OpenDocumentName("red", ElemNamespace = "draw")]
    public string? Red { get; set; }

    /// <summary>
    /// The draw:green attribute specifies together with the attributes draw:blue and draw:red a
    /// non destructive filter for a linear transformation of the white balance of a pixel image. See 20.94.
    /// </summary>
    /// <remarks>
    /// The draw:green attribute specifies the offset for the green color channel.
    ///
    /// The draw:green attribute has the data type signedZeroToHundredPercent 18.3.30.
    /// </remarks>
    [OpenDocumentName("green", ElemNamespace = "draw")]
    public string? Green { get; set; }

    /// <summary>
    /// The draw:blue attribute specifies together with the attributes draw:green and draw:red a
    /// non destructive filter for a linear transformation of the white balance of a pixel image.
    /// </summary>
    /// <remarks>
    /// If any of these three attributes is specified, an offset is applied to each pixel of an image while is it
    /// rendered.The offsets for each color channel is given as a percentage in the range of -100% to
    /// +100%.
    ///
    /// These offsets is scaled to the range -2^bits to 2^bits, where bits is the number of bits reserved for
    /// each color channel within the image.If the resulting value is less than 0 it is set to 0 and if it is
    /// greater than the maximum possible value it is set to the maximum.
    ///
    /// Note: For example, if the draw:blue attribute has the value 50% and the blue color channel has
    /// 8 bits, then 128 is added to the blue color value of each pixel inside the image before it is
    /// rendered.If draw:blue has the value -50% then 128 is subtracted.
    ///
    /// The draw:blue attribute specifies the offset for the blue color channel.
    ///
    /// The draw:blue attribute has the data type signedZeroToHundredPercent 18.3.30.
    /// </remarks>
    [OpenDocumentName("blue", ElemNamespace = "draw")]
    public string? Blue { get; set; }

    /// <summary>
    /// The draw:gamma attribute specifies a value that sets the output gamma of a bitmap or raster
    /// graphic.
    /// </summary>
    /// <remarks>
    /// The draw:gamma attribute has the data type percent 18.3.23.
    /// </remarks>
    [OpenDocumentName("gamma", ElemNamespace = "draw")]
    public string? Gamma { get; set; }

    /// <summary>
    /// The draw:luminance attribute specifies a signed percentage value that sets the output
    /// luminance of a bitmap or raster graphic.
    /// </summary>
    /// <remarks>
    /// The draw:luminance attribute has the data type zeroToHundredPercent 18.3.41.
    /// </remarks>
    [OpenDocumentName("luminance", ElemNamespace = "draw")]
    public string? Luminance { get; set; }

    /// <summary>
    /// The draw:contrast attribute specifies a signed percentage value that sets the output contrast
    /// of a bitmap or raster graphic.
    /// </summary>
    /// <remarks>
    /// The draw:contrast attribute has the data type percent 18.3.23.
    /// </remarks>
    [OpenDocumentName("contrast", ElemNamespace = "draw")]
    public string? Contrast { get; set; }

    /// <summary>
    /// The draw:color-mode attribute sets the output of colors from a source bitmap or raster
    /// graphic.
    /// </summary>
    /// <remarks>
    /// The defined values for the draw:color-mode attribute are:
    ///
    /// * greyscale: image is displayed using intensity only.
    /// * mono: image is displayed in black and white.
    /// * standard: image is displayed without modification by the draw:color-mode attribute.
    /// * watermark: colors are modified to make the resulting image transparent.
    ///
    /// The values of the draw:color-mode attribute are greyscale, mono, watermark or
    /// standard.
    /// </remarks>
    [OpenDocumentName("color-mode", ElemNamespace = "draw")]
    public string? ColorMode { get; set; }

    /// <summary>
    /// See §7.15.13 of [XSL].
    ///
    /// If wrapping is disabled, it is implementation-defined whether the overflow text is visible or hidden.
    /// If the text is hidden consumers may support a scrolling to access the text.
    /// </summary>
    /// <remarks>
    /// The values of the fo:wrap-option attribute are no-wrap or wrap.
    /// </remarks>
    [OpenDocumentName("wrap-option", ElemNamespace = "fo")]
    public string? WrapOption { get; set; }

    /// <summary>
    /// fo:padding-right 20.213,
    /// Paddings are of type non-negative lengths
    /// </summary>
    [OpenDocumentName("padding-right", ElemNamespace = "fo")]
    public Measurement? PaddingRight { get; set; }

    /// <summary>
    /// fo:padding-left 20.212,
    /// Paddings are of type non-negative lengths
    /// </summary>
    [OpenDocumentName("padding-left", ElemNamespace = "fo")]
    public Measurement? PaddingLeft { get; set; }

    /// <summary>
    /// fo:padding-top 20.214,
    /// Paddings are of type non-negative lengths
    /// </summary>
    [OpenDocumentName("padding-top", ElemNamespace = "fo")]
    public Measurement? PaddingTop { get; set; }

    /// <summary>
    /// fo:padding-bottom 20.211,
    /// Paddings are of type non-negative lengths
    /// </summary>
    [OpenDocumentName("padding-bottom", ElemNamespace = "fo")]
    public Measurement? PaddingBottom { get; set; }

    /*
        The <style:graphic-properties> element has the following attributes:

        dr3d:ambientcolor 20.67,
        dr3d:backface-culling 20.69,
        dr3d:back-scale 20.68,
        dr3d:closeback 20.70,
        dr3d:close-front 20.71,
        dr3d:depth 20.72,
        dr3d:diffuse-color 20.73,
        dr3d:edge-rounding 20.74,
        dr3d:edge-rounding-mode 20.75,
        dr3d:emissive-color 20.76,
        dr3d:end-angle 20.77,
        dr3d:horizontal-segments 20.78,
        dr3d:lightingmode 20.79,
        dr3d:normals-direction 20.80,
        dr3d:normals-kind 20.81,
        dr3d:shadow 20.82,
        dr3d:shininess 20.83,
        dr3d:specular-color 20.84,
        dr3d:texture-filter 20.85,
        dr3d:texture-generation-mode-x 20.88,
        dr3d:texture-generation-mode-y 20.89,
        dr3d:texture-kind 20.86,
        dr3d:texture-mode 20.87,
        dr3d:verticalsegments 20.90,
        draw:auto-grow-height 20.91,
        draw:auto-grow-width 20.92,
        draw:blue 20.94,
        draw:caption-angle 20.95,
        draw:caption-angle-type 20.96,
        draw:caption-escape 20.97,
        draw:caption-escape-direction 20.98,
        draw:caption-fit-line-length 20.99,
        draw:caption-gap 20.100,
        draw:captionline-length 20.101,
        draw:caption-type 20.102,
        draw:color-inversion 20.103,
        draw:color-mode 20.104,
        draw:contrast 20.105,
        draw:decimal-places 20.106,
        draw:draw-aspect 20.107,
        draw:end-guide 20.108,
        draw:end-line-spacinghorizontal 20.109,
        draw:end-line-spacing-vertical 20.110,
        draw:fill 20.111,
        draw:fill-color 20.112,
        draw:fill-gradient-name 20.113,
        draw:fill-hatch-name 20.114,
        draw:fill-hatch-solid 20.115,
        draw:fill-image-height 20.116,
        draw:fillimage-name 20.117,
        draw:fill-image-ref-point 20.118,
        draw:fill-image-refpoint-x 20.119,
        draw:fill-image-ref-point-y 20.120,
        draw:fill-image-width 20.121,
        draw:fit-to-contour 20.122,
        draw:fit-to-size 20.123,
        draw:framedisplay-border 20.124,
        draw:frame-display-scrollbar 20.126,
        draw:framemargin-horizontal 20.125,
        draw:frame-margin-vertical 20.127,
        draw:gamma 20.128,
        draw:gradient-step-count 20.130,
        draw:green 20.129,
        draw:guidedistance 20.131,
        draw:guide-overhang 20.132,
        draw:image-opacity 20.133,
        draw:line-distance 20.134,
        draw:luminance 20.135,
        draw:marker-end 20.136,
        draw:marker-end-center 20.137,
        draw:marker-end-width 20.138,
        draw:markerstart 20.139,
        draw:marker-start-center 20.140,
        draw:marker-start-width 20.141,
        draw:measure-align 20.142,
        draw:measure-vertical-align 20.143,
        draw:oledraw-aspect 20.144,
        draw:opacity 20.145,
        draw:opacity-name 20.146,
        draw:parallel 20.147,
        draw:placing 20.148,
        draw:red 20.149,
        draw:secondaryfill-color 20.150,
        draw:shadow 20.151,
        draw:shadow-color 20.152,
        draw:shadowoffset-x 20.153,
        draw:shadow-offset-y 20.154,
        draw:shadow-opacity 20.155,
        draw:show-unit 20.156,
        draw:start-guide 20.157,
        draw:start-line-spacinghorizontal 20.158,
        draw:start-line-spacing-vertical 20.159,
        draw:stroke 20.160,
        draw:stroke-dash 20.161,
        draw:stroke-dash-names 20.162,
        draw:strokelinejoin 20.163,
        draw:symbol-color 20.165,
        draw:textarea-horizontal-align 20.166,
        draw:textarea-vertical-align 20.167,
        draw:tile-repeat-offset 20.168,
        draw:unit 20.173,
        draw:visible-area-height 20.169,
        draw:visible-area-left 20.170,
        draw:visible-area-top 20.171,
        draw:visible-area-width 20.172,
        draw:wrap-influence-on-position 20.174,
        fo:background-color 20.175,
        fo:border 20.176.2,
        fo:border-bottom 20.176.3,
        fo:border-left 20.176.4,
        fo:border-right 20.176.5,
        fo:border-top 20.176.6,
        fo:clip 20.179,
        fo:margin 20.198,
        fo:margin-bottom 20.199,
        fo:margin-left 20.200,
        fo:margin-right 20.201,
        fo:margin-top 20.202,
        fo:max-height 20.203,
        fo:max-width 20.204,
        fo:min-height 20.205.1,
        fo:min-width 20.206,
        fo:padding 20.210,
        fo:wrap-option 20.223,
        style:background-transparency 20.240,
        style:borderline-width 20.241,
        style:border-line-width-bottom 20.242,
        style:border-linewidth-left 20.243,
        style:border-line-width-right 20.244,
        style:border-linewidth-top 20.245,
        style:editable 20.257,
        style:flow-with-text 20.259,
        style:horizontal-pos 20.290,
        style:horizontal-rel 20.291,
        style:mirror 20.313,
        style:number-wrapped-paragraphs 20.318,
        style:overflow-behavior 20.319,
        style:print-content 20.323.2,
        style:protect 20.326.2,
        style:rel-height 20.331,
        style:rel-width 20.332.1,
        style:repeat 20.333,
        style:run-through 20.343,
        style:shadow 20.349,
        style:shrink-to-fit 20.350,
        style:vertical-pos 20.387,
        style:vertical-rel 20.388,
        style:wrap 20.390,
        style:wrap-contour 20.391,
        style:wrap-contour-mode 20.392,
        style:wrap-dynamic-threshold 20.393,
        style:writing-mode 20.394.2,
        svg:fill-rule 20.396,
        svg:height 20.397.1,
        svg:stroke-color 20.398,
        svg:stroke-linecap 20.164,
        svg:stroke-opacity 20.399,
        svg:stroke-width 20.400,
        svg:width 20.403,
        svg:x 20.401,
        svg:y 20.402.1,
        text:anchor-page-number 20.407,
        text:anchor-type 20.408,
        text:animation 20.409,
        text:animation-delay 20.410,
        text:animation-direction 20.411,
        text:animation-repeat 20.412,
        text:animation-start-inside 20.413,
        text:animation-steps 20.414
        text:animation-stop-inside 20.415.

        The<style:graphic-properties> element has the following child elements:

        <style:background-image> 17.3,
        <style:columns> 17.12
        <text:list-style> 16.30.

     */
}
