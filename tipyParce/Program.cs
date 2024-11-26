string value = "102";
int result = 0;
if (int.TryParse(value, out result)) // verifica se inteiro e guarda valor no result usando "out"
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

