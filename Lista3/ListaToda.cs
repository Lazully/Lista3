using System;
using System.Globalization;

namespace Lista3
{
    class ListaTodas
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine(" ============ Lista 3 - Arrays, Listas e Métodos ============");
            #region Escolha

            Console.WriteLine($"{Environment.NewLine}Escolha o exercício que você quer ver: {Environment.NewLine}" +
                $"1. A {Environment.NewLine}" + //feito
                $"2. B {Environment.NewLine}" + //feito
                $"3. C {Environment.NewLine}" + //feito
                $"4. (Exercício 1) {Environment.NewLine}" + //feito
                $"5. (Exercício 2) {Environment.NewLine}" + //feito
                $"6. (Exercício 3) {Environment.NewLine}" +
                $"7. (Exercício 4) {Environment.NewLine}" +
                $"8. (Exercício 5) {Environment.NewLine}" +
                $"9. (Exercício 6) {Environment.NewLine}" +
                $"10. Exemplo de inverter ordem do vetor. ");
            op = Convert.ToInt32(Console.ReadLine());
            #endregion

            switch (op)
            {
                case 1:     //feito
                    int[] array = LerNumeros(4, "Entre com nota da Prova1:");
                    ImprimirNumeros(array);
                    break;
                case 2:     //feito
                    int[] array2 = LerEntradas();//não sei oq coloca dentro do parenteses
                    ImprimirEntradas(array2);
                    break;
                case 3:     //feito
                    int[] array3 = LerAleatorio();
                    ImprimirAleatorio(array3);
                    break;
                case 4:     //feito
                    int[] array4 = LerDezVetores(10);
                    ImprimirEntradas(array4);
                    break;
                case 5:     //feito
                    int[] array5 = LerMatriculas(10);
                    ImprimirNumeros(array5);
                    break;
                case 6:     //feito
                    int numero = 0;
                    int[] dados = new int[100];
                    int count = 0;
                    do
                    {
                        Console.WriteLine("Entre com um valor: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        dados[count] = numero;
                        count++;
                    } while (numero != 999);

                    count--;
                    int[] vetorInvertido = new int[count];

                    for (int i = count - 1; i >= 0; i--)
                    {
                        vetorInvertido[(count - 1) - i] = dados[i];
                    }

                    foreach (var num in vetorInvertido)
                        Console.WriteLine(num);

                    break;
                case 7:     //feito
                    Console.WriteLine("Abaixo, informe a matrícula dos alunos: ");
                    int[] array7 = LerMatriculas(10);

                    break;
                case 8: //feito
                    Console.Clear();
                    NotasProvas();
                    break;
                case 9:
                    Console.Clear();
                    int[] array9 = LerDezVetores(10);
                    SomaImpar(array9);
                    break;

                case 10: //exemplo
                    Console.WriteLine("Entre com uma frase ou palavra: ");
                    var invertido = Console.ReadLine().ToCharArray();
                    InverterOrdemFast(invertido);

                    for (int i = 0; i < invertido.Length; i++)
                        Console.Write(invertido[i]);
                    break;
            }
            Console.WriteLine($"{Environment.NewLine}Aperte qualquer tecla para encerrar o programa. ");
            Console.ReadKey();
        }
        //exercício A - case 1
        public static int[] LerNumeros(int numeroDeLeituras, string msg = "Entre com o número: ")
        {
            Console.Clear();

            int[] arrayNumeros = new int[numeroDeLeituras];

            for (int i = 0; i < numeroDeLeituras; i++)
            {
                Console.WriteLine(msg);
                arrayNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arrayNumeros;
        }

        public static void ImprimirNumeros(int[] arrayNum)
        {
            for (int i = 0; i < arrayNum.Length; i++) //pode fazer um foreach(int num in arrayNum)
            {
                Console.WriteLine(arrayNum[i] + " ");
            }
        }
        //exercício B - case 2
        public static int[] LerEntradas()
        {
            Console.Clear();
            int tam;

            Console.WriteLine("Infome um valor para a quantidade de entradas: ");
            tam = Convert.ToInt32(Console.ReadLine());

            int[] vetorEntradas = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine($"Infome um valor inteiro para a posição {i + 1}: ");
                vetorEntradas[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vetorEntradas;
        }

        public static void ImprimirEntradas(int[] arrayNumeros)
        {
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine($"=== Valores informados === {Environment.NewLine}Posição {i + 1}: {arrayNumeros[i]}");
            }
        }

        //exercício C - case 3
        public static int[] LerAleatorio()
        {
            Console.Clear();
            int qtdEntrada;

            Console.WriteLine($"Informe quantos valores você quer gerar aleatóriamente: ");
            qtdEntrada = Convert.ToInt32(Console.ReadLine());

            int[] vetorLer = new int[qtdEntrada];

            return vetorLer;
        }

        public static void ImprimirAleatorio(int[] arrayAleatorio)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arrayAleatorio.Length; i++)
            {
                int numero = r.Next(0, 100);//gera um numero aleatório no intervalo entre 0 e 100
                Console.WriteLine($"Valores gerados aleatóriamente: {Environment.NewLine}{i + 1}º: {numero}");
            }
        }

        //Exercício 1 - case 4
        public static int[] LerDezVetores(int num = 10)
        {
            Console.Clear();
            int[] recebeValor = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com o valor {i + 1}: ");
                recebeValor[i] = Convert.ToInt32(Console.ReadLine());
            }
            return recebeValor;
        }

        //Exercício 2 - case 5 (reutilizável no exercíco 4)
        public static int[] LerMatriculas(int num)
        {
            Console.Clear();
            int[] Matriculas = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com a matrícula {i + 1}: ");
                int novaMatriculas = Convert.ToInt32(Console.ReadLine());

                if (ValidarMatricula(novaMatriculas, Matriculas))
                {
                    Matriculas[i] = novaMatriculas;
                }
                else
                    i--;
            }
            return Matriculas;
        }

        private static bool ValidarMatricula(int novaMatriculas, int[] matriculas)
        {
            bool Existente = true;
            foreach (int matricula in matriculas)
            {
                if (matricula == novaMatriculas)
                    return false;
            }
            return Existente;
        }

        //exercício 3 - case 6 não consegui fazer.
        public static int[] LerExercicio3()
        {
            Console.Clear();
            int qtdEntrada;

            Console.WriteLine($"Informe quantos valores você quer: ");
            qtdEntrada = Convert.ToInt32(Console.ReadLine());

            int[] vetorLer = new int[qtdEntrada];

            return vetorLer;
        }

        private static void If999(int[] tam)
        {
            int lerAuxiliar;
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < tam.Length - 1; i++)
            {
                Console.WriteLine($"Escreva um valor para a posição {i + 1}");
                lerAuxiliar = Convert.ToInt32(Console.ReadLine());
                int[] vetAux = new int[lerAuxiliar];
            }
        }

        //inverter a ordem de um vetor
        public static char[] InverterOrdem(char[] vetorChar)
        {
            char[] vetorRetorno = new char[vetorChar.Length];

            for (int i = vetorChar.Length - 1; i >= 0; i--)
            {
                vetorRetorno[(vetorChar.Length - 1) - i] = vetorChar[i];
            }
            return vetorRetorno;
        }

        public static void InverterOrdemFast(char[] vetorChar) //gasta metade de memória RAM em relação ao Inverter Ordem
        {
            char[] vetorRetorno = new char[vetorChar.Length];

            for (int i = 0; i < vetorChar.Length / 2; i++)
            {
                int indexOposto = (vetorChar.Length - 1) - i;
                char aux = vetorChar[i];
                vetorChar[i] = vetorChar[indexOposto];
                vetorChar[indexOposto] = aux;
            }

        }

        //ler 3 notas e colocar em vetor - case 8

        public static void NotasProvas() {

            Console.WriteLine("Entre com numero de alunos");
            int numAlunos = Convert.ToInt32(Console.ReadLine());

            int[] MediasAlunos = new int[numAlunos];
            for (int i = 0; i < numAlunos; i++)
            {
                MediasAlunos[i] = MediaProvas();
            }

            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine($"Aluno {i}{Environment.NewLine} Nota: {MediasAlunos[i]}");
            }

           
        }
        public static int MediaProvas()
        {
            Console.WriteLine("Insira as notas conforme pedido.");

            int[] notas = new int[3];
            int media = 0;
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Entre com a nota {i + 1}: ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

              
            }
            media = (notas[0] + notas[1]) / 2;
            if (media > 5)
                Console.WriteLine("Aprovado! ");
            else
                Console.WriteLine("Reprovado! ");
            return media;
           

            //for (int j = 0; j == 2; j++)
            //{
            //    float media = guardaNota / 2;
            //    if (media > 5)
            //    {
            //        Console.WriteLine("Aprovado! ");
            //    }
            //    else
            //        Console.WriteLine("Reprovado! ");
            //}
        }

        //soma impar
        public static void SomaImpar(int[] recebeValor)
        {
            int[] vetorAux = new int[recebeValor.Length];
            int i = 0, j = 0;
            int[] somaImpar = new int[10];

            for (i = 0; i <= 10; i++)
            {
                if (vetorAux[i] % 2 == 1 && vetorAux[i] <= 10)
                {
                    somaImpar[j] += vetorAux[i];//soma = soma + contaN
                }
            }
            Console.WriteLine($"{Environment.NewLine}Soma dos ímpares: {somaImpar}");
        }
    }
}


