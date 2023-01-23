using System;
class Aula25{
    static void Main(){
        int num1=Convert.ToInt32(Console.ReadLine());
        dobrar1(ref num1);
        Console.WriteLine(num1);

        int num2=Convert.ToInt32(Console.ReadLine());
        dobrar2(ref num2);
        Console.WriteLine(num2);
    }

    static void dobrar1(ref int valor1){
        valor1*=2;
    }

    static void dobrar2(ref int valor2){
        valor2*=2;
    }

}