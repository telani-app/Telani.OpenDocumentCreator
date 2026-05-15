using System.Globalization;
using Telani.SourceGenerator;

namespace OpenDocumentCreator.DataTypes;

/// <summary>
/// Protection level of a cell
/// </summary>
[StringValueGenerator]
public enum CellProtectionLevel
{
    /// <summary>
    /// if cell content is a formula, it is not displayed. It can be replaced by changing the cell content.
    /// </summary>
    [StringValue("formula-hidden")]
    FormularHidden,

    /// <summary>
    /// cell content is not displayed and cannot be edited. If content is a formula, the formula result is not displayed
    /// </summary>
    [StringValue("hidden-and-protected")]
    HiddenAndProtected,

    /// <summary>
    /// formula responsible for cell content is neither hidden nor protected.
    /// </summary>
    [StringValue("none")]
    None,

    /// <summary>
    /// cell content can not be edited.
    /// </summary>
    [StringValue("protected")]
    CellProtected,

    /// <summary>
    /// cell content can not be edited. If content is a formula, it is not displayed. A formula result is displayed.
    /// </summary>
    [StringValue("protected-formula-hidden")]
    ProtectedAndFormulaHidden,
}

/// <summary>
/// Vertical alignment
/// </summary>
[StringValueGenerator]
public enum VerticalAlign
{
    /// <summary>
    /// top
    /// </summary>
    [StringValue("top")]
    Top,

    /// <summary>
    /// middle
    /// </summary>
    [StringValue("middle")]
    Middle,

    /// <summary>
    /// bottom
    /// </summary>
    [StringValue("bottom")]
    Bottom,

    /// <summary>
    /// automatic
    /// </summary>
    [StringValue("automatic")]
    Automatic,
}

/// <summary>
/// Type safe boolean value
/// </summary>
[StringValueGenerator]
public enum OpenDocBoolean
{
    /// <summary>
    /// True
    /// </summary>
    [StringValue("true")]
    True,

    /// <summary>
    /// False
    /// </summary>
    [StringValue("false")]
    False,
}

/// <summary>
/// This specifies the source of a text-align attribute.
/// </summary>
[StringValueGenerator]
public enum TextAlignSource
{
    /// <summary>
    /// Content alignment uses the value of the fo:text-align attribute.
    /// </summary>
    [StringValue("fix")]
    Fix,

    /// <summary>
    /// Content alignment uses the value-type of the cell.
    /// </summary>
    /// <remarks>
    /// The default alignment for a cell value-type string is left, for other value-types it is right.
    /// </remarks>
    [StringValue("value-type")]
    ValueType,
}

/// <summary>
///  Wrap options
/// </summary>
[StringValueGenerator]
public enum WrapOption
{
    /// <summary>
    /// wrap is not allowed
    /// </summary>
    [StringValue("no-wrap")]
    NoWarp,

    /// <summary>
    /// wrap is allowed
    /// </summary>
    [StringValue("wrap")]
    Wrap,
}

/// <summary>
/// Align text
/// </summary>
[StringValueGenerator]
public enum TextAlign
{
    /// <summary>
    /// start (left if text is left to right)
    /// </summary>
    [StringValue("start")]
    Start,

    /// <summary>
    /// end (right if text is left to right)
    /// </summary>
    [StringValue("end")]
    End,

    /// <summary>
    /// left
    /// </summary>
    [StringValue("left")]
    Left,

    /// <summary>
    /// right
    /// </summary>
    [StringValue("right")]
    Right,

    /// <summary>
    /// center
    /// </summary>
    [StringValue("center")]
    Center,

    /// <summary>
    /// justify
    /// </summary>
    [StringValue("justify")]
    Justify,
}

/// <summary>
/// Font weight, how thick a font should be
/// </summary>
[StringValueGenerator]
public enum FontWeight
{
    /// <summary>
    /// normal
    /// </summary>
    [StringValue("normal")]
    Normal,

    /// <summary>
    /// bold
    /// </summary>
    [StringValue("bold")]
    Bold,

    /// <summary>
    /// thin, hairline
    /// </summary>
    [StringValue("100")]
    Font100,

    /// <summary>
    /// Ultra light
    /// </summary>
    [StringValue("200")]
    Font200,

    /// <summary>
    /// light
    /// </summary>
    [StringValue("300")]
    Font300,

    /// <summary>
    /// normal
    /// </summary>
    [StringValue("400")]
    Font400,

    /// <summary>
    /// Medium
    /// </summary>
    [StringValue("500")]
    Font500,

    /// <summary>
    /// Semi-Bold
    /// </summary>
    [StringValue("600")]
    Font600,

    /// <summary>
    /// Bold
    /// </summary>
    [StringValue("700")]
    Font700,

    /// <summary>
    /// Extra bold
    /// </summary>
    [StringValue("800")]
    Font800,

    /// <summary>
    /// Black / Heavy
    /// </summary>
    [StringValue("900")]
    Font900,
}

/// <summary>
/// The different writing modes in which ways text can flow.
/// </summary>
[StringValueGenerator]
public enum WritingMode
{
    /// <summary>
    /// Left to right and then top to bottom.
    /// </summary>
    [StringValue("lr-tb")]
    Lrtb,

    /// <summary>
    /// Right to left and then top to bottom
    /// </summary>
    [StringValue("rl-tb")]
    Rltb,

    /// <summary>
    /// Top to bottom, then right to left.
    /// </summary>
    [StringValue("tb-rl")]
    Tbrl,

    /// <summary>
    /// Top to bottom, then left to right.
    /// </summary>
    [StringValue("tb-lr")]
    Tblr,

    /// <summary>
    /// Left to right.
    /// </summary>
    [StringValue("lr")]
    LR,

    /// <summary>
    /// Right to left.
    /// </summary>
    [StringValue("rl")]
    RL,

    /// <summary>
    /// Top to bottom.
    /// </summary>
    [StringValue("tb")]
    TB,

    /// <summary>
    /// TODO: Lookup what this value does.
    /// </summary>
    [StringValue("page")]
    Page,
}

/// <summary>
/// The direction a text should be rendered. Either left-to-right or right-to-left.
/// </summary>
[StringValueGenerator]
public enum TextDirection
{
    /// <summary>
    /// left to right, text is rendered in the direction specified by the style:writing-mode attribute
    /// </summary>
    [StringValue("ltr")]
    LeftToRight,

    /// <summary>
    /// top to bottom, characters are vertically stacked but not rotated
    /// </summary>
    [StringValue("ttb")]
    TopToBottom,
}

/// <summary>
/// Where and how is a rotation aligned?
/// </summary>
[StringValueGenerator]
public enum RotationAlign
{
    /// <summary>
    /// Text is rotated and may overlap with other cells if the text is longer than the length of the cell.
    /// Borders and background are positioned parallel to the text, whereby the edge that is named by the
    /// attribute value aligns with the corresponding edge of the cell's original position.
    /// </summary>
    [StringValue("top")]
    Top,

    /// <summary>
    /// Text is rotated and may overlap with other cells if the text is longer than the length of the cell.
    /// Borders and background are positioned parallel to the text, whereby the edge that is named by the
    /// attribute value aligns with the corresponding edge of the cell's original position.
    /// </summary>
    [StringValue("center")]
    Center,

    /// <summary>
    /// Text is rotated and may overlap with other cells if the text is longer than the length of the cell.
    /// Borders and background are positioned parallel to the text, whereby the edge that is named by the
    /// attribute value aligns with the corresponding edge of the cell's original position.
    /// </summary>
    [StringValue("bottom")]
    Bottom,

    /// <summary>
    /// Text is rotated and aligned within the cell
    /// Borders and Background are unchanged
    /// </summary>
    [StringValue("none")]
    None,
}

/// <summary>
/// See §7.19.2 of [XSL].
/// </summary>
[StringValueGenerator]
public enum BreakValue
{
    /// <summary>
    /// No break shall be forced.
    /// </summary>
    [StringValue("auto")]
    Auto,

    /// <summary>
    /// Imposes a break-before condition with a context consisting of column-areas.
    /// </summary>
    [StringValue("column")]
    Column,

    /// <summary>
    /// Imposes a break-before condition with a context consisting of page-areas.
    /// </summary>
    [StringValue("page")]
    Page,
}

/// <summary>
/// The different types of styles are distinguished by this type.
/// </summary>
[StringValueGenerator]
public enum StyleFamily
{
    /// <summary>
    /// family name of styles for charts.
    /// </summary>
    [StringValue("chart")]
    Chart,

    /// <summary>
    /// family name of styles for drawing pages.
    /// </summary>
    [StringValue("drawing-page")]
    DrawingPage,

    /// <summary>
    /// family name of styles for graphic elements.
    /// </summary>
    [StringValue("graphic")]
    Graphic,

    /// <summary>
    /// family name of styles for paragraphs.
    /// </summary>
    [StringValue("paragraph")]
    Paragraph,

    /// <summary>
    /// family name of styles for presentations.
    /// </summary>
    [StringValue("presentation")]
    Presentation,

    /// <summary>
    /// family name of styles for ruby text.
    /// </summary>
    [StringValue("ruby")]
    Ruby,

    /// <summary>
    /// family name of styles for tables.
    /// </summary>
    [StringValue("table")]
    Table,

    /// <summary>
    /// family name of styles for table cells.
    /// </summary>
    [StringValue("table-cell")]
    TableCell,

    /// <summary>
    /// family name of styles for table columns.
    /// </summary>
    [StringValue("table-column")]
    TableColumn,

    /// <summary>
    /// family name of styles for table rows.
    /// </summary>
    [StringValue("table-row")]
    TableRow,

    /// <summary>
    /// family name of styles for text.
    /// </summary>
    [StringValue("text")]
    Text,
}

/// <summary>
/// 5.9.13. Definitions of Units of Measure
///
/// The units of measure in this Recommendation have the following definitions:
/// </summary>
[StringValueGenerator]
public enum Unit
{
    /// <summary>
    /// See [ISO31]
    /// </summary>
    [StringValue("cm")]
    CM,

    /// <summary>
    /// See [ISO31]
    /// </summary>
    [StringValue("mm")]
    MM,

    /// <summary>
    /// 2.54cm
    /// </summary>
    [StringValue("in")]
    Inch,

    /// <summary>
    /// 1/72in
    /// </summary>
    [StringValue("pt")]
    PT,

    /// <summary>
    /// 12pt
    /// </summary>
    [StringValue("pc")]
    PC,

    /// <summary>
    /// XSL interprets a 'px' unit to be a request for the formatter to choose a device-dependent measurement that
    /// approximates viewing one pixel on a typical computer monitor.
    /// </summary>
    [StringValue("px")]
    PX,

    /// <summary>
    /// There is only one relative unit of measure, the "em". The definition of "1em" is equal to the current font
    /// size. For example, a value of "1.25em" is 1.25 times the current font size.
    /// </summary>
    [StringValue("em")]
    EM,
}

/// <summary>
/// Can be used for:
/// * style:leader-style in style:tab-stop
/// * style:line-style in style:footnote-sep
/// * style:text-line-through-style in style:text-properties
/// * style:text-overline-style in style:text-properties
/// * style:text-underline-style in style:text-properties
/// </summary>
[StringValueGenerator]
public enum LineStyle
{
    /// <summary>
    /// text has no line through it.
    /// </summary>
    [StringValue("none")]
    None,

    /// <summary>
    /// text has a solid line through it.
    /// </summary>
    [StringValue("solid")]
    Solid,

    /// <summary>
    /// text has a dotted line through it.
    /// </summary>
    [StringValue("dotted")]
    Dotted,

    /// <summary>
    /// text has a dashed line through it.
    /// </summary>
    [StringValue("dash")]
    Dash,

    /// <summary>
    /// text has a dashed line whose dashes are longer than the ones from the dashed
    /// line for value dash through it.
    /// </summary>
    [StringValue("long-dash")]
    LongDash,

    /// <summary>
    /// text has a line whose repeating pattern is a dot followed by a dash through it.
    /// </summary>
    [StringValue("dot-dash")]
    DotDash,

    /// <summary>
    /// text has a line whose repeating pattern is two dots followed by a dash through it.
    /// </summary>
    [StringValue("dot-dot-dash")]
    DotDotDash,

    /// <summary>
    /// text has a wavy line through it.
    /// </summary>
    [StringValue("wave")]
    Wave,
}

/// <summary>
/// Values for the draw:stroke attribute, 20.160
/// </summary>
[StringValueGenerator]
public enum StrokeValue
{
    /// <summary>
    /// There should not be a visible stroke.
    /// </summary>
    [StringValue("none")]
    None,

    /// <summary>
    /// The stroke should be a solid line.
    /// </summary>
    [StringValue("solid")]
    Solid,

    /// <summary>
    /// The stroke should be dashed.
    /// </summary>
    [StringValue("dash")]
    Dash,
}

/// <summary>
/// Values for the draw:fill attribute, 20.111
/// </summary>
[StringValueGenerator]
public enum FillValue
{
    /// <summary>
    /// the drawing object is not filled.
    /// </summary>
    [StringValue("none")]
    None,

    /// <summary>
    /// the drawing object is filled with the color specified by the draw:fill-color attribute.
    /// </summary>
    [StringValue("solid")]
    Solid,

    /// <summary>
    /// the drawing object is filled with the hatch specified by the draw:fill-hatch-name attribute.
    /// </summary>
    [StringValue("hatch")]
    Hatch,

    /// <summary>
    /// the drawing object is filled with the gradient specified by the draw:fill-gradient-name attribute.
    /// </summary>
    [StringValue("gradient")]
    Gradient,

    /// <summary>
    /// the drawing object is filled with the bitmap specified by the draw:fill-imagename attribute.
    /// </summary>
    [StringValue("bitmap")]
    Bitmap,
}

/// <summary>
/// The different line types available.
/// </summary>
[StringValueGenerator]
public enum LineType
{
    /// <summary>
    /// A double line
    /// </summary>
    [StringValue("double")]
    DoubleLine,

    /// <summary>
    /// A single line
    /// </summary>
    [StringValue("single")]
    SingleLine,

    /// <summary>
    /// No line
    /// </summary>
    [StringValue("none")]
    None,
}

/// <summary>
/// The style:table-centering attribute specifies whether tables are centered horizontally
/// and/or vertically on the page.This attribute only applies to spreadsheet documents.
///
/// The default is to align the table to the top-left or top-right corner of the page, depending of its
/// writing direction.
/// </summary>
[StringValueGenerator]
public enum TableCentering
{
    /// <summary>
    /// tables should be centered horizontally on the pages where they appear.
    /// </summary>
    [StringValue("horizontal")]
    Horizontal,

    /// <summary>
    /// tables should be centered vertically on the pages where they appear.
    /// </summary>
    [StringValue("vertical")]
    Vertical,

    /// <summary>
    /// tables should be centered both horizontally and vertically on the pages where they
    /// appear.
    /// </summary>
    [StringValue("both")]
    Both,

    /// <summary>
    /// tables should not be centered both horizontally or vertically on the pages where they
    /// appear.
    /// </summary>
    [StringValue("none")]
    None,
}

/// <summary>
/// 20.184 fo:font-style
///
/// See §7.8.7 of [XSL].
///
/// This attribute is evaluated for any [UNICODE] character whose script type is Latin. 20.348
///
/// In the OpenDocument XSL compatible namespace, the fo:font-style attribute does not
/// support backslant and inherit values.
/// </summary>
[StringValueGenerator]
public enum FontStyle
{
    /// <summary>
    /// Normal
    /// </summary>
    [StringValue("normal")]
    Normal,

    /// <summary>
    /// Italic
    /// </summary>
    [StringValue("italic")]
    Italic,

    /// <summary>
    /// Oblique
    /// </summary>
    [StringValue("oblique")]
    Oblique,
}

/// <summary>
/// 19.749 table:visibility
///
/// The table:visibility attribute specifies whether a row or column is visible.,
///
/// The default value for this attribute is visible.
/// </summary>
[StringValueGenerator]
public enum Visibility
{
    /// <summary>
    ///  a row or column is not visible as the result of applying a filter.
    /// </summary>
    [StringValue("visible")]
    Visible,

    /// <summary>
    /// a row or column is not visible.
    /// </summary>
    [StringValue("collapsed")]
    Collapsed,

    /// <summary>
    /// a row or column is visible.
    /// </summary>
    [StringValue("filter")]
    Filter,
}

/// <summary>
/// A line style, that is for example used as a border for a cell.
/// It contains: a style, color and width.
/// </summary>
public readonly record struct CompoundLine
{
    /// <summary>
    /// The thickness of the line.
    /// </summary>
    public Measurement LineWidth { get; }

    /// <summary>
    /// The style of the line.
    /// </summary>
    public LineStyle LineStyle { get; }

    /// <summary>
    /// The stroke or color of the line.
    /// </summary>
    public Color LineColor { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CompoundLine"/> struct.
    /// </summary>
    /// <param name="width">The width of the line</param>
    /// <param name="style">The style of the line</param>
    /// <param name="color">The stroke of the line</param>
    public CompoundLine(Measurement width, LineStyle style, Color color)
    {
        LineStyle = style;
        LineWidth = width;
        LineColor = color;
    }

    /// <inheritdoc/>
    public override string ToString() => LineWidth.ToString() + " " + LineStyle.GetStringValue() + " " + LineColor.ToString();
}

/// <summary>
/// A Measurement is a decimal value and a unit together.
/// </summary>
public readonly record struct Measurement : IComparable<Measurement>
{
    /// <summary>
    /// The unit of the measurement
    /// </summary>
    public Unit Unit { get; }

    /// <summary>
    /// The decimal value of the measurement
    /// </summary>
    public decimal Measure { get; }

    /// <inheritdoc />
    public override string ToString() => Measure.ToString(CultureInfo.InvariantCulture) + Unit.GetStringValue();

    /// <inheritdoc />
    public int CompareTo(Measurement other)
    {
        if (Unit == other.Unit)
        {
            return Measure.CompareTo(other.Measure);
        }
        var thisConverted = ConvertToMM(this);
        var otherConverted = ConvertToMM(other);

        return thisConverted.CompareTo(otherConverted);
    }

    private static decimal ConvertToMM(Measurement measurement)
     => measurement.Unit switch
     {
         Unit.MM => measurement.Measure,
         Unit.CM => measurement.Measure * 10,
         Unit.Inch => measurement.Measure * 25.4m,
         Unit.PT => measurement.Measure / 72.0m * 25.4m,
         Unit.PC => measurement.Measure * 12 / 72.0m * 25.4m,
         _ => throw new InvalidOperationException("This unit can not be compared (yet)"),
     };

    /// <summary>
    /// Initializes a new instance of the <see cref="Measurement"/> struct.
    /// </summary>
    /// <param name="m">the value of the Measurement</param>
    /// <param name="u">the unit of the Measurement</param>
    public Measurement(decimal m, Unit u = Unit.PT)
    {
        Unit = u;
        Measure = m;
    }

    /// <summary>
    /// Operator less than
    /// </summary>
    /// <param name="left">The left value</param>
    /// <param name="right">The right value</param>
    /// <returns>true if left is smaller than right</returns>
    public static bool operator <(Measurement left, Measurement right) => left.CompareTo(right) < 0;

    /// <summary>
    /// Operator less than or equal
    /// </summary>
    /// <param name="left">The left value</param>
    /// <param name="right">The right value</param>
    /// <returns>true if left is smaller or equal than right</returns>
    public static bool operator <=(Measurement left, Measurement right) => left.CompareTo(right) <= 0;

    /// <summary>
    /// Operator greater than
    /// </summary>
    /// <param name="left">The left value</param>
    /// <param name="right">The right value</param>
    /// <returns>true if left is larger than right</returns>
    public static bool operator >(Measurement left, Measurement right) => left.CompareTo(right) > 0;

    /// <summary>
    /// Operator greater than or equal
    /// </summary>
    /// <param name="left">The left value</param>
    /// <param name="right">The right value</param>
    /// <returns>true if left is larger or equal than right</returns>
    public static bool operator >=(Measurement left, Measurement right) => left.CompareTo(right) >= 0;
}

/// <summary>
/// A color value to use in OpenDocument files.
/// </summary>
public readonly record struct Color
{
    /// <summary>
    /// The red component.
    /// </summary>
    public byte Red { get; }

    /// <summary>
    /// The green component.
    /// </summary>
    public byte Green { get; }

    /// <summary>
    /// The blue component.
    /// </summary>
    public byte Blue { get; }

    /// <summary>
    /// A boolean switch to enable special transparent color.
    /// </summary>
    public bool Transparent { get; }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (Transparent)
        {
            return "transparent";
        }
        else
        {
            return string.Format(CultureInfo.InvariantCulture, "#{0:X2}{1:X2}{2:X2}", Red, Green, Blue);
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color"/> struct.
    /// </summary>
    /// <param name="transparent">If true then the special transparent value is used.</param>
    public Color(bool transparent)
    {
        Red = 0;
        Green = 0;
        Blue = 0;
        Transparent = transparent;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color"/> struct.
    /// </summary>
    /// <param name="r">the red component</param>
    /// <param name="g">the green component</param>
    /// <param name="b">the blue component</param>
    public Color(byte r, byte g, byte b)
    {
        Red = r;
        Green = g;
        Blue = b;
        Transparent = false;
    }
}
