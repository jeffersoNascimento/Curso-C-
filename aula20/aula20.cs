using System;
class Aula20{
    static void Main(){

        int[] num=new int[10];

        /*int i=0;
        while(i<num.Length){
            num[i]=0;
            Console.WriteLine(num[i]);
            i++;
        }*/

        int i=num.Length-1;
        while(i>0){
            num[i]=0;
            Console.WriteLine(num[i]);
            i--;
        }
    }
}