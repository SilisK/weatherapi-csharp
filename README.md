<div align=center>
    <img src=./Images/asp-icon.png width=128 />
</div>
<div align=center>
    <h1>C# ASP .NET | Weather API</h1>
</div>
<div>
    <p>
        This is a simple API that uses the ASP.NET framework to perform basic CRUD operations
        on a JSON schema.
    </p>
    <p>
        The output forms a data structure as follows:
    </p>
</div>

```json
Location => {
    "id": "",
    "city": "",
    "state": "",
    "forecast": {
      "date": "",
      "temperatureC": 0,
      "temperatureF": 0,
      "summary": ""
    }
  }
```

<div>
    <h2>Endpoints</h2>
    <ul>
        <li>
        <b>All locations: </b>
            <code>
                http://localhost:{port}/location
            </code>
        </li>
        <li>
        <b>Location by id: </b>
            <code>
                http://localhost:{port}/location/{id}
            </code>
        </li>
        <li>
        <b>Forecast demo: </b>
            <code>
                http://localhost:{port}/weatherforecast
            </code>
        </li>
    </ul>
</div>

<div>
    <h2>Run the API</h2>
    <p>
        Depending on your operating system, the way you run this app may differ. Refer to the official documentation about running .NET on your system <a href=https://dotnet.microsoft.com>here</a>.
    </p>
    <p>
        I recommend using <a href=https://www.postman.com>Postman</a> to send requests to the endpoints, but you can build out a front end to go along with the API.
    </p>
    <p>
        If you were able to install dotnet successfully on your device, you can use <code>dotnet run</code> in the project directory to start the server.
    </p>
</div>