using System;
class Aula11{
    static void Main(){
        /*Conversões de tipos
        Conversão implícita:
        int n1=10;
        float n2=n1;
        Console.WriteLine(n2);
        */
        
        //Conversão explícita
        float n1=10.5f;
        int n2=(int)n1;//type cast
        Console.WriteLine(n2);

        int vInt=20;
        short vShort=(short)vInt;//type cast
        Console.WriteLine(vShort);
    }
}