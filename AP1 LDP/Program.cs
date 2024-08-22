using System;

class Program
{
    static void Main()

    {  
        do
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso em quilogramas: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            string categoriaIMC;
            if (imc <= 18.5)
            {
                categoriaIMC = "Abaixo do peso";
            }
            else if (imc <= 24.9)
            {
                categoriaIMC = "Normal";
            }
            else if (imc <= 29.9)
            {
                categoriaIMC = "Sobrepeso";
            }
            else
            {
                categoriaIMC = "Obeso";
            }

            string faixaEtaria;
            if (idade <= 12)
            {
                faixaEtaria = "Criança";
            }
            else if (idade <= 18)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            Console.Write("Deseja gerar um novo relatório para outra pessoa? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "S")
            {
            break;
            }
        } while (true);
    }
}
