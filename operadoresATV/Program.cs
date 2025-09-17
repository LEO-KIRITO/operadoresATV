/* Exercício-01
int num1;
int num2;
int num3;
int resultado;


// Utilizando operadores aritméticos com variáveis

Console.WriteLine("Insira a primeira nota");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a terceira nota");
num3 = Convert.ToInt16(Console.ReadLine());

resultado = num1 + num2 + num3;
Console.WriteLine($"A soma das notas é: {resultado}");

resultado = resultado / 3;
Console.WriteLine($"A média das notas é: {resultado}");
*/

/* Exercício-02
int temperaturaC;
int temperaturaF;
Console.WriteLine("Digite a temperatura em Celsius:");
temperaturaC = Convert.ToInt32(Console.ReadLine());
temperaturaF = (temperaturaC * 9 / 5) + 32;
Console.WriteLine($"A temperatura em Fahrenheit é: " + temperaturaF);
*/

/* Exercício-03
double lado1;
double lado2;
double area;

Console.WriteLine("Digite o valor do perimeiro lado");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado");
lado2 = Convert.ToDouble(Console.ReadLine());

area = lado1 * lado2;
Console.WriteLine($"O valor da área é: {area}");
*/

/* Exercício-04
double altura;
double base1;
double area;

Console.WriteLine("Digite o valor da altura");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da base");
base1 = Convert.ToDouble(Console.ReadLine());

area = (altura * base1) / 2 ;
Console.WriteLine($"O valor da área é: {area}");
*/

/* Exercício-05
const double pi = 3.14;
double raio;
double resultado;

Console.WriteLine("Digite o valor do raio");
raio = Convert.ToDouble(Console.ReadLine());
resultado = pi * raio * raio;
Console.WriteLine($"O valor da área é: {resultado}");
*/


/* exercício-06
double largura;
double altura;
double resultado;
Console.WriteLine("Digite a largura do retângulo:");
largura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo:");
altura = Convert.ToDouble(Console.ReadLine());
resultado = 2 * (largura + altura);
Console.WriteLine($"O perímetro do retângulo é: {resultado}");
*/
