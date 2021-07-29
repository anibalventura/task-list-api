# Task List REST API

[![ASP.NET Core](https://img.shields.io/static/v1?label=ASP.NET%20Core&message=5.0&color=purple)](https://dotnet.microsoft.com/apps/aspnet)
[![License](https://img.shields.io/static/v1?label=License&message=MIT&color=blue)](LICENCE)

## Overview

| API                     | Description                   | Request body | Response body       |
| ----------------------- | ----------------------------- | ------------ | ------------------- |
| `GET /api/Task`         | Get all tasks                 | None         | List of tasks       |
| `GET /api/Task/{id}`    | Get a task by ID              | None         | Task                |
| `POST /api/Task`        | Add a new task                | Task         | Task                |
| `PUT /api/Task/{id}`    | Update an existing task       | Task         | None                |
| `DELETE /api/Task/{id}` | Delete a task                 | None         | None                |

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

Copyright (c) 2021 Anibal Ventura

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
