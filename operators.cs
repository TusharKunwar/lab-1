// Arithmetic Operators
int a = 13, b = 7;
Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraction: " + (a - b));
Console.WriteLine("Multiplication: " + (a * b));
Console.WriteLine("Division: " + (a / b));
Console.WriteLine("Modulus: " + (a % b));

// Relational Operators
Console.WriteLine("Is a equal to b? " + (a == b));
Console.WriteLine("Is a not equal to b? " + (a != b));
Console.WriteLine("Is a greater than b? " + (a > b));
Console.WriteLine("Is a less than or equal to b? " + (a <= b));

// Logical Operators
bool x = true, y = false;
Console.WriteLine("x AND y: " + (x && y));
Console.WriteLine("x OR y: " + (x || y));
Console.WriteLine("NOT x: " + (!x));


// Unary Operators
int d = 5;
Console.WriteLine("Unary plus: " + (+d));
Console.WriteLine("Unary minus: " + (-d));
Console.WriteLine("Pre-increment: " + (++d)); // Increment before use
Console.WriteLine("Post-increment: " + (d++)); // Use, then increment
Console.WriteLine("Value after post-increment: " + d);



// Bitwise Operators
int e = 6, f = 3;
Console.WriteLine("Bitwise AND: " + (e & f));
Console.WriteLine("Bitwise OR: " + (e | f)); 
Console.WriteLine("Bitwise XOR: " + (e ^ f));