using System.Runtime.InteropServices;

double A = 0, B = 0;

Console.Write("Insira o valor A: ");
A = Double.Parse(Console.ReadLine());

Console.Write("Insira o valor B: ");
B = Double.Parse(Console.ReadLine());

Console.WriteLine($"Resultado da soma: {A + B}");
Console.WriteLine($"Resultado da subtração: {A - B}");

if (B == 0){
   Console.WriteLine("Resultado da divisão: indeterminado(±∞)"); 
}
else{
    Console.WriteLine($"Resultado da divisão: {A/B}"); 
}

Console.WriteLine($"Resultado da multiplicação: {A * B}");


