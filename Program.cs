using System;

namespace Media_de_alunos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];

            Console.WriteLine("Média dos alunos\n----------------");
            for (var contador = 0; contador < 2; contador++)
            {
                Console.WriteLine("digite o nome do aluno");
                nomes[contador] = Console.ReadLine();
                while (nomes[contador] == "")
                {
                    Console.Write("Você nâo digitou nenhum nome \nDigite o nome novamente: ");
                    nomes[contador] = Console.ReadLine();
                }
                Console.WriteLine("digite a primeira nota");
                nota1[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a segunda nota");
                nota2[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a terceira nota");
                nota3[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a quarta nota");
                nota4[contador] = float.Parse(Console.ReadLine());
                while (nota1[contador] > 10 || nota2[contador] > 10 || nota3[contador] > 10 || nota4[contador] > 10)
                {
                    Console.WriteLine("Nota inválida.");
                    Console.WriteLine("digite a primeira nota");
                    nota1[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a segunda nota");
                    nota2[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a terceira nota");
                    nota3[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a quarta nota");
                    nota4[contador] = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Alunos cadastrados!\n");
            for (var contador = 0; contador < 2; contador++)
            {
                Console.WriteLine(nomes[contador]);
                Console.WriteLine(nota1[contador]);
                Console.WriteLine(nota2[contador]);
                Console.WriteLine(nota3[contador]);
                Console.WriteLine(nota4[contador]);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine($"Média\n------------------");
            for (var contador = 0; contador < 2; contador++)
            {
                Console.WriteLine(nomes[contador]);
                Console.WriteLine("Média: "+notas(nota1[contador], nota2[contador], nota3[contador], nota4[contador])+"\n------------------");
            }
            
            
        }
        static float notas(float a, float b, float c, float d){
            float resu = (a + b + c + d) / 4;
            return resu;
        }
    }
}
