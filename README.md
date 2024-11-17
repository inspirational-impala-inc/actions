# Actions Demo Repo

This is a simple .NET Application designed to show different applications of GitHub Actions

## Applications and Workflows

| Application               | Workflow                                                         | Status                                                                                                                         |
| ------------------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------ |
| Continuous Integration    | [Continuous Integration](.github/workflows/ci.yml)               | ![CI](https://github.com/inspirational-impala-inc/dotnet-package/actions/workflows/ci.yml/badge.svg)                           |
| Continuous Deployment     | [Continuous Deployment](.github/workflows/cd.yml)                | ![CD](https://github.com/inspirational-impala-inc/dotnet-package/actions/workflows/cd.yml/badge.svg)                           |
| Publish package           | [Publish Package](.github/workflows/publish-package.yml)         | ![Publish Package](https://github.com/inspirational-impala-inc/dotnet-package/actions/workflows/publish-package.yml/badge.svg) |
| Connect to Azure via OIDC | [Log into Azure with OpenID Connect](.github/workflows/oidc.yml) | ![OIDC](https://github.com/inspirational-impala-inc/dotnet-package/actions/workflows/oidc.yml/badge.svg)                       |

## Publishing new package versions

1. Create a new branch.
2. Bump the version in the `dotnet-package.csproj` file.
3. Push the branch to the server.
4. Run the `Publish Package` workflow.
