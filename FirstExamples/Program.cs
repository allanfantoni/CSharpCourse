using System;

namespace FirstExamples
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            #region Example 1 - Saída de dados

            //double x = 10.35784;
            //int y = 32;
            //string z = "Maria";
            //char w = 'F';

            //Console.Write("Olá mundo!");
            //Console.WriteLine("Bom dia!");
            //Console.WriteLine("Até mais.");

            //Console.WriteLine();
            //Console.WriteLine(x);
            //Console.WriteLine(x.ToString("F2"));
            //Console.WriteLine(x.ToString("F4"));
            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine("RESULTADO = " + x);
            //Console.WriteLine("O valor do troco é " + x + " reais"); // concatenação
            //Console.WriteLine("O valor do troco é {0:F3} reais", x); // placeholder {0} {1} {2}
            //Console.WriteLine($"O valor do troco é {x:F3} reais"); // interpolation {varName1} {varName2}
            //Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            //Console.WriteLine();
            //Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            //Console.ReadLine();

            #endregion

            #region Exercise 1

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            //Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            //Console.WriteLine();
            //Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            //Console.WriteLine();
            //Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            //Console.WriteLine($"Arredondado (três casa decimais): {medida:F3}");
            //Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

            #endregion

            #region Example 2 - Conversão implícita e casting

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a;

            //Console.WriteLine(b);

            #endregion

            #region Example 3 - Operadores aritméticos

            //int n1 = 3 + 4 * 2;
            //int n2 = (3 + 4) * 2;
            //int n3 = 17 % 3;
            //double n4 = 10.0 / 8.0;

            //double a = 1.0, b = -3.0, c = -4.0;
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            //Console.WriteLine(a);
            //Console.WriteLine(delta);
            //Console.WriteLine(x1);

            #endregion

            #region Example 4 - Entrada de dados

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            #endregion

            #region Example 5 - Entrada de dados (parte 2)

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine());

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3]);

            //Console.WriteLine("Você digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2);
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2"));

            #endregion

            #region Exercise 2

            //Console.WriteLine("Entre com seu nome completo:");
            //var nomeCompleto = Console.ReadLine();

            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //var quartos = Console.ReadLine();

            //Console.WriteLine("Entre com o preço de um produto:");
            //var precoProduto = Console.ReadLine();

            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            //string[] vet = Console.ReadLine().Split(' ');
            //var sobrenome = vet[0];
            //var idade = vet[1];
            //var altura = vet[2];

            //Console.WriteLine("Saída esperada (números reais com duas casas decimais):");
            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(quartos);
            //Console.WriteLine(precoProduto);
            //Console.WriteLine(sobrenome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);

            #endregion

            #region Example 6 - Membros estáticos

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            
            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2")); 
            
            #endregion
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}