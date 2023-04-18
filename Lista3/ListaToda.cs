using System;

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
                case 1:
                    int[] array = LerNumeros(4, "Entre com nota da Prova1:");
                    ImprimirNumeros(array);
                    break;
                case 2:
                    int[] array2 = LerEntradas();//não sei oq coloca dentro do parenteses
                    ImprimirEntradas(array2);
                    break;
                case 3:
                    int[] array3 = LerAleatorio();
                    ImprimirAleatorio(array3);
                    break;
                case 4:
                    int[] array4 = LerDezVetores(10);
                    ImprimirEntradas(array4);
                    break;
                case 5:
                    int[] array5 = LerMatriculas(10);
                    ImprimirNumeros(array5);
                    break;
                case 6:
                    int[] array6 = LerExercicio3();
                    If999(array6);
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
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

            int[] vetorLer = new int [qtdEntrada];

            return vetorLer;
        }

        public static void ImprimirAleatorio(int[] arrayAleatorio)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arrayAleatorio.Length; i++)
            {
                int numero = r.Next(0, 100);//gera um numero aleatório no intervalo entre 0 e 100
                Console.WriteLine($"Valores gerados aleatóriamente: {Environment.NewLine}{i+1}º: {numero}");
            }
        }
       
        //Exercício 1 - case 4
        public static int[] LerDezVetores(int num = 10)
        {
            Console.Clear();
            int[] recebeValor = new int[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com o vetor {i + 1}: ");
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
            for (int i = 0; i<tam.Length-1; i++)
            {
                Console.WriteLine($"Escreva um valor para a posição {i + 1}");
                lerAuxiliar = Convert.ToInt32(Console.ReadLine());
                int[] vetAux = new int[lerAuxiliar];
            }
        }

        //inverter a ordem de um vetor
        public static char InverterOrdem(char[] vetorChar)
        {
            char[] vetorRetorno = new char[vetorChar.Lenght];

            for (int i = vetorChar.Lenght - 1; i >= 0; i--)
            {
                vetorRetorno[(vetorChar.Lenght-1) - i] = vetorChar[i];
            }
            return vetorRetorno;
        }

        public static void InverterOrdemFast(char[] vetorChar) //gasta metade de memória RAM em relação ao Inverter Ordem
        {
            char[] vetorRetorno = new char[vetorChar.Lenght];

            for (int i = 0; i < vetorChar.Length/2; i++)
            {
                int indexOposto = (vetorChar.Length - 1) - i;
                char aux = vetorChar[i];
                vetorChar[i] = vetorChar[indexOposto];
                vetorChar[indexOposto] = aux;
            }
            
        }

    }
}


