// valores literales

Console.WriteLine('b'); //char para un solo carácter

Console.WriteLine('Hello World!'); //Error porque ' es para un solo carácter

Console.WriteLine(123); //int para enteros

/* Float Type    Precision
 ----------------------------
  float         ~6-9 digits
  double        ~15-17 digits
  decimal        28-29 digits
*/

Console.WriteLine(0.25F); //Indicamos el dato que usamos (f)

Console.WriteLine(2.625); //Predeterminado es float si no ponemos sufijo literal. 

Console.WriteLine(12.39816m); // Valor decimal al agregar (m)

//Boleanos

Console.WriteLine(true);
Console.WriteLine(false);

/* Tipos de datos aprendidos

* string para palabras, frases o cualquier dato alfanumérico para presentación, no cálculo
* char para un solo carácter alfanumérico
* int para un número entero
* decimal para un número con un componente fraccionado
* bool para un valor true/false
*/

// Declaración de variables

/* Consideraciones importantes sobre los nombres de variables

1- Los nombres de variables pueden contener caracteres alfanuméricos 
y el carácter de subrayado. No se permiten caracteres especiales, 
como el símbolo # (también conocido como símbolo de almohadilla) o el símbolo del dólar $.

2-Los nombres de variables deben comenzar por una letra alfabética o 
un carácter de subrayado, no por un número.

3- Los nombres de variable distinguen mayúsculas de minúsculas, 
lo que significa que string Value; y string value; son dos variables diferentes.

4- Los nombres de variable no deben ser una palabra clave de C#. 
Por ejemplo, no se pueden usar las siguientes declaraciones de variable: 
decimal decimal; ni string string;.
*/

/* Convenciones de creación de código de las variables:

1- Los nombres de variable deben usar camel case, que es un estilo de escritura 
que usa una letra en minúscula al principio de la primera palabra y 
una letra en mayúscula al principio de cada palabra siguiente. 
Por ejemplo, string thisIsCamelCase;.

2- Los nombres de variable deben comenzar con una letra alfabética. 
Los desarrolladores usan el carácter de subrayado para un fin especial, 
así que intente no usarlo por ahora.

3- Los nombres de variables deben ser descriptivos y significativos en la aplicación. 
Elija un nombre para la variable que represente el tipo de datos que va a contener.

4- Los nombres de variable deben ser una o varias palabras completas anexadas. 
No use contracciones ni abreviaturas, ya que el nombre de la variable 
(y, por tanto, su fin) puede no quedar claro para otros usuarios que lean el código.

5- Los nombres de variables no deben incluir el tipo de datos de la variable. 
Puede que aparezcan algunas recomendaciones para usar un estilo como string strValue;.
Esas recomendaciones ya no son pertinentes.
*/

// Ejemplo de nombres de variables

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

// Ejercicio: trabajo con variables

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

string secondName = "Gonzales"; // declaración y el establecimiento 
//del valor de la variable en una línea de código. 
//Esta técnica se denomina inicializar la variable.
Console.WriteLine(secondName); 

// Variables locales con tipo implícito


var message = "Hello world"; // La palabra clave var indica al compilador de C# 
//que el tipo de datos está implícito en el valor asignado.
// message = 10.703m; error al tener otro tipo de dato

/* la palabra clave var hasta ahora:

1- La palabra clave var indica al compilador que deduzca el tipo de datos de la variable 
en función del valor en el que se inicializa.

2- Es probable que vea la palabra clave var mientras lee el código de otras personas; 
sin embargo, debe usar el tipo de datos cuando sea posible.
*/

// Ejercicio

string firstName = ("Bob");
int inbox = (3);
decimal temperatureAmbient = (34.4m);

Console.WriteLine(
    "Hello, " + firstName + 
    " You have " + inbox + 
    "in your inbox. " + 
    "The temperature is " 
    + temperatureAmbient 
    + " celsius."
    );
