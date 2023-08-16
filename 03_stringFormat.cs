// Ejercicio: Formato de cadenas literales en C#

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!"); // Para usar comillas dentro del texto

// Para mostrar ruta de acceso. Se usa doble \\

Console.WriteLine("c:\\soruce\\repos");

// Aplicación de formato a la salida mediante secuencias de escape de caracteres

Console.WriteLine("Generating invoices for customer \"Constoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadena textual

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Aplicación de formato a la salida mediante literales de cadena textual

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.Write(@"c:\invoices");

// Caracteres de escape Unicode

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Aplicación de formato a la salida mediante caracteres de escape Unicode

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Resumen

/*Esto es lo que ha aprendido sobre el formato de las cadenas literales hasta ahora:

1- Use secuencias de escape de caracteres cuando necesite insertar un carácter especial en una cadena literal, como una tabulación \t, una nueva línea \n o una comilla doble \".
2- Use un carácter de escape para la barra diagonal inversa \\ cuando necesite usar una barra diagonal inversa en todos los demás escenarios.
3- Use la directiva @ para crear un literal de cadena textual para conservar en una cadena todo el formato de espacios en blanco y todos los caracteres de barra diagonal inversa.
4- Use \u junto con un código de cuatro caracteres para representar caracteres Unicode (UTF-16) en una cadena.
5- Es posible que los caracteres Unicode no se impriman correctamente, en función de la aplicación.
*/

//Combinación de cadenas mediante concatenación de cadenas

string firstName = "Bob";
string greeting = "Hello ";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message); 

//Evitación de variables intermedias

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// Combinación de cadenas mediante interpolación de cadenas

string message = greeting + " " + firstName + "!";

// Interpolación 

string message = $"{greeting} {firstName}!";

// Uso de la interpolación de cadenas para combinar una cadena literal y un valor de variable.

string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

// Uso de la interpolación de cadenas con varias variables y cadenas literales

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// Evitar las variables intermedias

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// Combinación de los literales textuales y la interpolación de cadenas
/*
Supongamos que necesita usar un literal textual en la plantilla. 
Puede usar juntos el símbolo @ de prefijo de literal textual y el símbolo $ 
de interpolación de cadenas.
*/

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

/* En este ejemplo, el símbolo $ le permite hacer referencia a la variable 
projectName entre corchetes, mientras que el símbolo @ permite usar el carácter \ 
sin escape.
*/

//Ejercicio

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

/* outpot:

View English output:
		c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
		c:\Exercise\ACME\ru-RU\data.txt

*/