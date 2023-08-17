// Sumas con conversión implícita de datos

/*  La reutilización de un símbolo para varios propósitos se denomina a veces 
"sobrecarga del operador" y sucede con frecuencia en C#. + para sumar y + para concatenar
*/

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Combinación de tipos de datos para forzar las conversiones implícitas de tipos

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Output: 
    Bob sold 7 widgets.

// Caso más avanzado de suma numérica y concatenación de cadenas

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

Output:
    Bob sold 77 widgets.

// En lugar de agregar la variable intwidgetsSold al literal int 7, 
// el compilador trata todo como una cadena y lo concatena todo junto.

// Adición de paréntesis para aclarar la intención al compilador

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

Output:
    Bob sold 14 widgets.

// El símbolo de paréntesis () se convierte en otro operador sobrecargado.

// Realización de operaciones matemáticas

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

Output:
    Sum: 12
    Difference: 2
    Product: 35
    Quotient: 1 // int no puede contener decimales.

// Incorporación de código para efectuar la división con datos decimales literales

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Output:
    Decimal quotient: 1.4

// Otras formas

decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;

// Resultados con errores. 

int decimalQuotient = 7 / 5.0m;
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;

// Incorporación de código para efectuar la división con datos decimales literales
// conversión de tipo de datos de int a decimal.

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Output:
    1.4

// Escritura de código para determinar el resto después de la división de enteros
/* 
El operador de módulo % le indica el resto de la división int. 
Lo que realmente se aprende de esto es si un número es divisible por otro.
*/

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

Output:
    Modulus of 200 / 5 : 0
    Modulus of 7 / 5 : 2

// Orden de las operaciones

/*
En matemáticas, PEMDAS es un acrónimo que ayuda a los alumnos a recordar el orden de las operaciones. El orden es:

1- Parentheses (paréntesis) (lo que se encuentra dentro del paréntesis se realiza primero)
2- Exponents (exponentes)
3- Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
4- Addition (suma) y Subtraction (resta) (de izquierda a derecha)
*/

// Escritura de código para practicar con el orden de las operaciones de C#

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

Output:
    23
    35
