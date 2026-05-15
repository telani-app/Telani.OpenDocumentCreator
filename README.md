# Telani.OpenDocumentCreator

A .NET library for creating OpenDocument (ODF) files such as spreadsheets (`.ods`).

The C# namespace is `OpenDocumentCreator` (no `Telani.` prefix) so this drop-in
replaces existing `using OpenDocumentCreator;` consumers. Only the NuGet package
id carries the `Telani.` prefix.

## Install

```xml
<PackageReference Include="Telani.OpenDocumentCreator" Version="*" />
```

The package is published to the
[telani-app GitHub Packages feed](https://github.com/orgs/telani-app/packages).
Add the feed to your `NuGet.Config`:

```xml
<configuration>
  <packageSources>
    <add key="github-telani" value="https://nuget.pkg.github.com/telani-app/index.json" />
  </packageSources>
  <packageSourceMapping>
    <packageSource key="github-telani">
      <package pattern="Telani.OpenDocumentCreator" />
    </packageSource>
  </packageSourceMapping>
</configuration>
```

To authenticate, set the env var
`NuGetPackageSourceCredentials_github-telani` to
`Username=<gh-user>;Password=<PAT>` where `<PAT>` is a classic token with the
`read:packages` scope.

## Quick example

```csharp
using OpenDocumentCreator;
using OpenDocumentCreator.Styles;
using OpenDocumentCreator.DataTypes;

var doc = new OpenDocumentSpreadsheet("My App");

var header = new OpenDocumentStyle
{
    Name = "Header",
    Family = StyleFamily.TableCell,
    TextProperties = new TextProperties { FontWeight = FontWeight.Bold },
};
doc.Styles.Add(header.Name, header);

var grid = new AutoGrid(doc, "Sheet1", nRows: 2, nColumns: 2, "30mm");
doc.Tables.Add(grid);

grid.WriteCell(0, 0, new OpenDocumentCell("Name") { Style = header });
grid.WriteCell(1, 0, new OpenDocumentCell("Value") { Style = header });
grid.WriteCell(0, 1, new OpenDocumentCell("answer"));
grid.WriteCell(1, 1, new OpenDocumentCell { FloatContent = 42 });

await using var fs = File.Create("out.ods");
await doc.Save(fs);
```

## Repo layout

| Path     | Purpose                                                              |
| -------- | -------------------------------------------------------------------- |
| `src/`   | The library, packaged as `Telani.OpenDocumentCreator`.               |
| `Tests/` | MSTest unit tests covering `AutoGrid`, `OpenDocumentCell`, etc.      |
| `DemoApp/` | Console app that exercises the library end-to-end and writes a `.ods` to `bin/.../out/planets.ods`. |

## Build & test

```bash
dotnet restore
dotnet build
dotnet test
dotnet run --project DemoApp
```

## Releasing

The `main` branch is continuously deployed by `.github/workflows/CD.yml`. Each
push:

1. Restores, builds, runs tests.
2. Builds the package in `Release`.
3. Uploads the `.nupkg` as a workflow artifact.
4. Pushes the package to the `telani-app` GitHub Packages feed.

The version comes from [Nerdbank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning)
via `version.json`; bump the major/minor there.
