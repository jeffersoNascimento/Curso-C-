using System;
class Aula08{
    static void Main(){
        //converter string em inteiro
        int n1,n2,soma;
        string nome;

        Console.Write("\nDigite o primeiro valor: ");
        n1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        n2=Convert.ToInt32(Console.ReadLine());
        soma=n1+n2;
        Console.WriteLine("A soma de {0} + {1} é igual a: {2}\n",n1,n2,soma);
    }
}