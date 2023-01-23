using System;
class Aula21{
    static void Main(){

        //int num=5;
        /*while(num<5){
            Console.WriteLine("Teste");
        }*/
        string senha="123";
        string senhaUser;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhaUser=Console.ReadLine();
        }while(senha != senhaUser);

        Console.WriteLine("Senha Correta");

    }
}