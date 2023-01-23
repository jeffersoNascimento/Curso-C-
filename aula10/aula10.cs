using System;
class Aula10{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){
        //Enumeradores (enum)
        //DiasSemana ds = DiasSemana.Domingo;
        //int ds=(int)DiasSemana.Sexta;
        DiasSemana ds = (DiasSemana)4;
        Console.WriteLine(ds);
    }
}