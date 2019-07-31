# gcp-detect-project-id

Detect project id running a .net core app inside a Google Compute Instance

## Steps

Clone repository inside a GCP instance

```bash
git clone https://github.com/reisbel/gcp-detect-project-id.git && cd gcp-detect-project-id
```

Restore the dependencies of the project.

```bash
dotnet restore
```

Run the project

```bash
dotnet run
```

```bash
Project-id: test-project-id
```
