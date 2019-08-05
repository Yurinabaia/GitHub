using System;
using System.Collections.Generic;
namespace ConsoleApp147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for(int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Vamos lá chaqualhar");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            List<int> VALOR = new List<int>();
            VALOR.Add(15);
            VALOR.Add(30);
            VALOR.Add(45);
            VALOR.Add(60);
            
            foreach(int obj in VALOR )
            {
                Console.WriteLine(obj);
            }
            List<string> list = new List<string>();
            list.Add("Naria");
            list.Add("Ana");
            list.Add("Pedro");
            list.Add("Arthur");
            list.Insert(0, "Nabaia");
            //Pecorrendo a lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //List count mostrta a quantidade de elementos têm na lista
            Console.WriteLine("Lista count: " + list.Count);
            //List.Find mosta se alguma palavra tem a letra x => x[0] == 'A', pela primeira ocorrência
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First: 'A' {0}", s1);
            //List.FindLast mostra se alguma palavra tem a letra x => x[0] == 'A', pela última ocorrência
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last: 'A' {0}", s2);
            //List.FindIndex mostra onde na posição tem a pessoa que começar com a letra 'A' , pela primeira ocorrência
            int Pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First possição : {0}", Pos1);
            //List.FindIndex mostra onde na posição tem a pessoa que começar com a letra 'A' , pela  última ocorrência
            int Pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last posição: {0}", Pos2);
            //Last significar último, find == encontra.
            Console.WriteLine("-----------------");
            //List.findAll encontra quantos caracter a palavra vai ser procurada, 5 caracter vai buscar apenas palavra com 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------");
            //Remove na lista, usando o list.Remove() que remove apenas 1 com a parametro dado;
            Console.WriteLine("Removendo apenas um objeto da lista, obj removeu Nabaia");
            list.Remove("Nabaia");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------");
            //List.RemoveALL(), remover varios usando um tipo de caracter
            Console.WriteLine("Removendo varios objetos da lista, apenas de referencia o primeiro caracter");
            list.RemoveAll(x => x[0] == 'A');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------");
            //List.RemoveAt() faz com que remover o objeto da lista atraves da posição do obj
            Console.WriteLine("Removendo apenas um objeto da lista, pela posição do obj// removeu a Naria");
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");
            //List.RemoveRange() faz com que remover o objeto da lista atraves da posição e de uma contagem
            Console.WriteLine("Removendo varios objetos e proseguir para baixo remoção, \nRemoveu pedro e se tivesse outro nome de baixo de pedro removia também");
            list.RemoveRange(0, 1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
