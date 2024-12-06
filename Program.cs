Console.Clear();

String sexo = ""; 
double altura = 0;


Console.WriteLine("Digite sua altura (m) ");
altura = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite seu sexo [M] ou [F]");
sexo = Console.ReadLine()!;

sexo.ToLower();

double conta_homem = altura * 72.7 - 58.0;
double conta_femeas = altura * 62.1 - 44.7;

if(sexo == "m"){

    Console.WriteLine($"Seu peso ideal é {conta_homem:N2}");
}

else{
    Console.WriteLine($"Seu peso ideal é {conta_femeas:N2}");

}