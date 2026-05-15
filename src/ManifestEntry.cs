namespace OpenDocumentCreator;

internal class ManifestEntry : OpenDocumentWritable
{
    internal override string OpenDocumentElementName => "file-entry";

    internal override string? NamespaceName => "manifest";

    [OpenDocumentName("full-path", ElemNamespace = "manifest")]
    public string FullPath { get; set; } = string.Empty;

    [OpenDocumentName("media-type", ElemNamespace = "manifest")]
    public string MediaTyp { get; set; } = string.Empty;
}
