/*
O que é o operador condicional?
O operador ?: condicional avalia uma expressão booleana e retorna um dos dois resultados, dependendo se a 
expressão booleana é avaliada como true ou false. O operador condicional 
é comumente referido como o operador condicional ternário.
*/
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");