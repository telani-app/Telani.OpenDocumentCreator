using OpenDocumentCreator.Styles;

namespace OpenDocumentCreator;

/// <summary>
/// A minimal interface to lookup styles
/// </summary>
public interface IStyleLookup
{
    /// <summary>
    /// Look up a style by name.
    /// </summary>
    /// <param name="s">the style name</param>
    /// <returns>the style</returns>
    /// <exception cref="System.InvalidOperationException">if the style was not found</exception>
    OpenDocumentStyle GetStyleByName(string s);
}