# Task List REST API

[![ASP.NET Core](https://img.shields.io/static/v1?label=ASP.NET%20Core&message=5.0&color=purple)](https://dotnet.microsoft.com/apps/aspnet)
[![License](https://img.shields.io/static/v1?label=License&message=MIT&color=blue)](LICENSE.md)

## Overview

| API                     | Description             | Request body | Response body |
| ----------------------- | ----------------------- | ------------ | ------------- |
| `GET /api/Task`         | Get all tasks           | None         | List of tasks |
| `GET /api/Task/{id}`    | Get a task by ID        | None         | Task          |
| `POST /api/Task`        | Add a new task          | Task         | Task          |
| `PUT /api/Task/{id}`    | Update an existing task | Task         | None          |
| `DELETE /api/Task/{id}` | Delete a task           | None         | None          |

## Build

- Visual Studio: Open `Program.cs` and build/run.
- Visual Studio Code: Open `Program.cs` and press F5 to build/run.

Or run in terminal `dotnet build && dotnet run`

## Swagger Enabled

To explore and test the available APIs simply run the project and use the Swagger UI.

`https://localhost:<port>/swagger/index.html`

## License

```xml
MIT License

Copyright (c) 2022 Anibal Ventura
```
