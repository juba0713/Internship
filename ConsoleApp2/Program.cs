// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
var x = 1;
var y = 2;
var result = MyLibrary.CalculatorMethods.Add(x, y);
Console.WriteLine(result);

string json = @"{
'XValue' : 2,
'YValue' : 3,
'Result' : 0
}";

var m = JsonConvert.DeserializeObject<EquationValue>(json);

if (m != null)
	{
	m.Result = MyLibrary.CalculatorMethods.Add(m.XValue, m.YValue);
	Console.WriteLine("Result: " + m.Result);
	}
else
	{
	Console.WriteLine("Could not calculate values");
	}

await AddNumbers();

async Task AddNumbers()
	{
	try

		{
		var httpClient = new HttpClient();
		var client = new OpenAPICalculator.CalculatorAPI("https://localhost:7174", httpClient);

		var equation = new OpenAPICalculator.Equation();
		equation.XValue = 6;

		equation.YValue = 6;
		equation.Result = 0;

		equation.Result = await client.AddAsync(equation);
		Console.WriteLine(equation.XValue + " plus " + equation.YValue + " equals " + equation.Result);
		Console.ReadLine();
		}
	catch (Exception ex)
		{
		Console.WriteLine(ex);
		Console.ReadLine();
		}
	}