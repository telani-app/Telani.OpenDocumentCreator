using System.Text;
using OpenDocumentCreator.Styles;

namespace OpenDocumentCreator;

/// <summary>
/// A simpler representation of a Column. A collection of
/// columns get passed to the AutoColumnProcessor.Apply method.
///
/// The main idea is here to only set the width with the constructor and let
/// AutoColumnProcessor deal with generating a TableColumnProperties style from that.
/// </summary>
public class AutoColumn
{
    /// <summary>
    /// The 'real' Column this AutoColumn created.
    /// </summary>
    public Column Column { get; private set; } = new Column();

    /// <summary>
    /// The TableColumnProperties contain all properties of the column.
    /// </summary>
    public TableColumnProperties Properties { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AutoColumn"/> class.
    /// </summary>
    /// <param name="width">target width for this column</param>
    public AutoColumn(Measurement width)
    {
        Properties = new TableColumnProperties
        {
            BreakBefore = BreakValue.Auto,
            ColumnWidth = width,
        };
    }
}
