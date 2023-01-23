using System;
class Aula18{
    static void Main(){
        //Matrizes e Vetores Bidimensionais
        int[,] n=new int[3,5];
        int[,] num=new int[2,2]{{10,20},{30,40}};

        /*
        10 20 30 40 50
        12 13 14 15 16
        50 40 30 20 10
        */
        n[0,0]=10; n[0,1]=20; n[0,2]=30; n[0,3]=40; n[0,4]=50;
        n[1,0]=12; n[1,1]=13; n[1,2]=14; n[1,3]=15; n[1,4]=16;
        n[2,0]=50; n[2,1]=40; n[2,2]=30; n[2,3]=20; n[2,4]=10;

        Console.WriteLine(num[0,1]);
        Console.WriteLine(n[1,0]);

    }
}