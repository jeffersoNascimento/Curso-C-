using System;
class Aula19{
    static void Main(){

        int[] num=new int[5];

        for(int i=1;i<num.Length;i++){
            num[i]=1;
        }

        for(int i=1;i<num.Length;i++){
            Console.WriteLine("Valor de num na posição{0}: {1}",i,num[i]);
        }

    }
}