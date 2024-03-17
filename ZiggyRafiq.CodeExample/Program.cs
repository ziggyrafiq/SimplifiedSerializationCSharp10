using System.Text.Json;
using ZiggyRafiq.CodeExample.Models;

Console.WriteLine("Hello, from Ziggy Rafiq!");

/**********************************************************************************************
 * Code Example One
 **********************************************************************************************/

// Create a Person record instance
var person = new Person { FirstName = "John", LastName = "Smith", Email ="John.Smith@email.com" };

// Serialize the record to JSON
string json = JsonSerializer.Serialize(person);

// Output the serialized JSON
Console.WriteLine(json);


/**********************************************************************************************
 * Code Example Two
 **********************************************************************************************/

// Deserialize the JSON string into a Person record
Person? personObject = JsonSerializer.Deserialize<Person>(json);

// Output the deserialized Person
Console.WriteLine(value: $"First Name: {personObject.FirstName}, Last Name: {personObject.LastName}, Email: {personObject.Email}");

