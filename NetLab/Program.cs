//API = Application Programming Interface
//Gränssnitt mellan applikationer eller mellan applikation och bibliotek.

//Databas 

//CRUD
//Create - Read - Update - Delete (Data)

//HTTP
//Request-response
//Header, body
//Request: URL, Metod
//Response

//REST
//Representational State Transfer
//Använder HTTP-protokoller för att göra CRUD-operationer
//"RESTful API som ger tillgång till en databas som innehåller X"

//URL
//Endpoint

using RestSharp;
using System.Text.Json;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new RestRequest("pokemon/420");
RestResponse respons = pokeClient.GetAsync(request).Result;

Pokemon p = JsonSerializer.Deserialize<Pokemon>(respons.Content);

Console.WriteLine(p.name);

Console.ReadLine();