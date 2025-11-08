using BYT3_2;

var calcAddition = new Calculator(2, 3, '+');
Console.WriteLine(calcAddition.Calculate());

var calcSubtraction = new Calculator(2, 3, '-');
Console.WriteLine(calcSubtraction.Calculate());

var calcMultiplication = new Calculator(2, 3, '*');
Console.WriteLine(calcMultiplication.Calculate());

var calcDivision = new Calculator(2, 3, '/');
Console.WriteLine(calcDivision.Calculate());

calcDivision = new Calculator(2, 0, '/');
try
{
    Console.WriteLine(calcDivision.Calculate());
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero cannot be performed");
}

var calcInvalid = new Calculator(2, 3, '!');
try
{
    Console.WriteLine(calcInvalid.Calculate());
}
catch (InvalidOperationException)
{
    Console.WriteLine("Invalid operation");
}