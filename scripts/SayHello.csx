#! "netcoreapp2.1"
#r "nuget:System.Net.Http, 4.3.3"

using System.Net;
using System.Net.Http;

String url = "http://localhost:5000/api/secure/sayHello";

async Task Default() {
    var handler = new HttpClientHandler {
        UseDefaultCredentials = true
    };
    var client = new HttpClient(handler);
    var result = await client.GetAsync(url);
    Console.WriteLine(result.StatusCode);
}

async Task UserPassword() {
    var domain = "";
    var username = "wk";
    var password = "1234";
    var handler = new HttpClientHandler {
        Credentials = new NetworkCredential($"{domain}\\{username}", password)
    };
    var client = new HttpClient(handler);
    var result = await client.GetAsync(url);
    Console.WriteLine(result.StatusCode);
}

await UserPassword();