using System;
class Aula12{
    static void Main(){
        //Comando condicional if
        double n1,n2,n3,n4,res,media; //double nota=7.5f;
        media=res=n1=n2=n3=n4=0;

        string resultado="Reprovado";

        Console.Write("Digite a primeira nota: ");
        n1=float.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        n2=float.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        n3=float.Parse(Console.ReadLine());
        Console.Write("Digite a quarta nota: ");
        n4=float.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;
        media=res/4f;

        if(media>=6){
            resultado="Aprovado";
        }
        Console.WriteLine("Nota: {0} - Resultado: {1}",media,resultado);
    }
}