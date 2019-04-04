# SAFE boiler

## Install pre-requisites

You'll need to install the following pre-requisites in order to build SAFE applications

-   The [.NET Core SDK](https://www.microsoft.com/net/download)
-   The [Yarn](https://yarnpkg.com/lang/en/docs/install/) package manager (you an also use `npm` but the usage of `yarn` is encouraged).
-   [Node LTS](https://nodejs.org/en/download/) installed for the front end components.
-   Fake: `dotnet tool install fake-cli -g`

## install client depedencies

```bash
- yarn install
```

## develop

### server

just use

```bash
dotnet watch run
```

### client

```bash
yarn webpack-dev-server
```

## build

### server

just use

```bash
dotnet build
```

### client

use the -p flag for webpack `--optimize-minimize --define process.env.NODE_ENV="production"`

```bash
yarn webpack-cli -p
```
