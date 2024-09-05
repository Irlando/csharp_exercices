/*
    Use o operador de igualdade
*/
//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

/*
Melhorar a verificação da igualdade de cadeia de caracteres
usando os métodos auxiliares internos da cadeia de caracteres
*/

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

/*
Use o operador de desigualdade
*/
//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

/*
Avaliar comparações
Maior do que >
Menor do que <
Maior do que ou igual a >=
Menor do que ou igual a <=
*/

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

/*
Usar um método que retorna um Boolean
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

/*
O que é a negação lógica?
*/
// These two lines of code will create the same output

//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));

/*
Operador de desigualdade versus negação lógica
*/
//int a = 7;
//int b = 6;
//Console.WriteLine(a != b); // output: True
//string s1 = "Hello";
//string s2 = "Hello";
//Console.WriteLine(s1 != s2); // output: False

string myValue1 = "Y";
string myValue2 = "y";
Console.WriteLine((myValue1.Trim().ToLower() != myValue2.Trim().ToLower()));