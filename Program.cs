const decimal TaxRate = 0.07m;

int a = 10, b = 5;
Console.WriteLine($"Addition: {a + b}");
Console.WriteLine($"Subtraction: {a - b}");
Console.WriteLine($"Multiplication: {a * b}");
Console.WriteLine($"Division: {a / b}");

Console.Write("Enter subtotal: ");
if (decimal.TryParse(Console.ReadLine(), out var subtotal))
    Console.WriteLine($"Total with 7% tax: {subtotal * (1 + TaxRate):C}");
else
    Console.WriteLine("Invalid amount.");
