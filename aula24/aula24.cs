using System;
class Aula24{
    static void Main(){
        //for(int i=0;i<2;i++){}
        int v1,v2; //int v1,v2,r;
        v1=int.Parse(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        //r=soma(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}",v1 ,v2 ,soma(v1,v2));
    }
    /*
    static void ola(){
        Console.WriteLine("------------------\nTeste");
        Console.WriteLine("Curso C#");
        Console.WriteLine("Youtube");
        Console.WriteLine("------------------\n");
    }
    */
    /*
    static void soma(int n1, int n2){
        int res=n1+n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}",n1 ,n2 ,res);
    }
    */
    static int soma(int n1, int n2){
        int res=n1+n2;
        return res;
    }
}