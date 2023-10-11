# Azure Functions Lab

## Overview

This will exmaple to create new Azure Functions with UnitTest

### Features

 - C#
 - Azure Functions
 - XUnit
 - GitHub Actions
 ## Requirements

The project requires [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Compatible IDEs

Tested on:

- Visual Studio Code (1.74.3)

## Useful commands

From the terminal/shell/command line tool, use the following commands to build, test and run the API.

### Build the project

```shell
$ dotnet build
```

### Run the tests

```shell
$ dotnet test
```

### Useful commands to test Azure Functions locally [more info](https://learn.microsoft.com/en-us/azure/azure-functions/functions-dotnet-class-library?tabs=v4%2Ccmd)

```shell
# Run functions locally
$ func start

# Deploy project files
$ func azure functionapp publish <FunctionAppName>
```

### Code coverage

```shell
# install dotnet coverage
$ dotnet tool install --global dotnet-coverage

# running code coverage
# from /src directory
$ dotnet-coverage collect 'dotnet test' -f xml -o 'coverage.xml'
```

Integration test
