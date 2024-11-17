# Actions Demo Repo

This is a simple .NET Application designed to show different applications of GitHub Actions

## Application 1: CI
### Applicable workflow
[Continuous Integration](.github/workflows/cd.yml)

## Application 2: CD
### Applicable workflow
[Continuous Deployment](.github/workflows/cd.yml)

## Application 3: Publish package
### Applicable workflow
[Publish Package](.github/workflows/publish-package.yml)

### Publishing a new package version

1. Create a new branch.
2. Bump the version in the `dotnet-package.csproj` file.
3. Push the branch to the server.
4. Run the `Publish Package` workflow.

## Application 4: Connect to Azure via OIDC
### Applicable workflow
[Run Azure CLI Login with OpenID Connect](.github/workflows/oidc.yml)
