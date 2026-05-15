namespace OpenDocumentCreator;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class OpenDocumentNameAttribute : Attribute
{
    public string? Name { get; }

    public string? ElemNamespace { get; set; }

    public OpenDocumentNameAttribute(string name) => Name = name;

    public OpenDocumentNameAttribute()
    {
    }
}