using System;

//exibe o título do programa no console
Console.WriteLine("--- SISTEMA DE SAÚDE ---");

//variavel de controle para o laço de repetição.
//começa com "s" para que o programa entre no loop pelo menos uma vez.
string opcao = "s";
//o laço while repetirá todo o código abaixo enquanto a varavel opcao for igual a "s".
while (opcao == "s")
{
    //solicita o nome do usuário
    Console.Write("Digite seu nome: ");
    //o "!" após o readline indica ao C# que o valor não será nulo
    string nome = Console.ReadLine()!;

    //solicita o peso e converte o texto digitado (string) para numero decimal (double)
    Console.Write("Digite seu peso (kg): ");
    double peso = double.Parse(Console.ReadLine()!);

    //solicita a altura e tambem converte para double
    Console.Write("Digite sua altura (m): ");
    double altura = double.Parse(Console.ReadLine()!);

    //calculo do imc
    double imc = peso / (altura * altura);

    //exibe o resultado usando Interpolação ($) e formatação de 2 casa decimais (:F2)
    Console.WriteLine($"{nome}, seu IMC é: {imc:F2}");


    //estrutura condicional para classificar o IMC calculado
    if (imc < 18.5)
        {
            //executado se o IMC for menor que 18.5
            Console.WriteLine($"{nome} ATENÇÃO! Você está abaixo do peso!");
        }

    else if (imc >= 18.5 && imc <= 24.9)
        {
            //executado se o IMC estiver entre 18.5 e 24.9 (uso do operador lógico &&)
            Console.WriteLine($"{nome}, seu peso está normal. PARABÉNS!");
        }

    else
        {
            //executado caso nenhuma das condições anteriores seja atendida (IMC > 24.9)
            Console.WriteLine($"{nome} CUIDADO! Você está com sobrepeso.");
        }

    //linha decorativa para separar as execuções no terminal
    Console.WriteLine ("--------------------------------------");

    //pergunta ao usuário se ele deseja realizar um novo cálculo
    Console.Write("Deseja continuar? (s/n): ");

    //atualiza a variavel opcao. Se o usuário digitar algo diferente de "s", o while encerrará.
    opcao = Console.ReadLine()!;
}

//mensagem final exibida apenas quando o loop while termina
Console.WriteLine("Promgrama finalizado. Até logo!");
