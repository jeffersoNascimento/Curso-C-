using System;
class Aula29{
    //Construtores e Destrutores
    public class Jogador{
        public int energia=100;
        public bool vivo=true;
        public string nome;
        //Construtor
        public Jogador(string n){   
            energia=100;
            vivo=true;
            nome=n;
        }
        //Destrutor
        ~Jogador(){
            Console.WriteLine("Jogador {0} foi destruido",nome);
        }
    }
    static void Main(){

        string nome1,nome2;
        Console.WriteLine("Digite o nome do Jogador1: ");
        nome1=Console.ReadLine();
        Console.WriteLine("Digite o nome do Jogador2: ");
        nome2=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador(nome2);

        Console.WriteLine("Jogador1: {0} / Energia: {1}",j1.nome,j1.energia);
        Console.WriteLine("Jogador2: {0} / Energia: {1}",j2.nome,j2.energia);
    }
}