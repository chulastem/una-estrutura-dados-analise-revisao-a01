internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sistema de triagem de sintomas!");
        Console.WriteLine("Por favor, responda às seguintes perguntas:");

        var nome = (string?)null;
        int idade;

        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine() ?? "";

        Console.Write("Informe a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        int porcentagem = 0;
        int tentativas = 0;
        string[] resposta = new string[4];

        // Pergunta 1 - Cartão de vacina em dia
        while (tentativas < 3)
        {
            Console.Write("Seu cartão de vacina está em dia? (SIM/NAO): ");
            resposta[0] = Console.ReadLine()??"".Trim().ToUpper();

            if (resposta[0] == "SIM")
            {
                break;
            }
            else if (resposta[0] == "NAO")
            {
                porcentagem += 10;
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 'SIM' ou 'NAO'.");
                tentativas++;

                if (tentativas >= 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico.");
                    Console.WriteLine("Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Environment.Exit(0);
                }
            }
        }
        tentativas = 0;
        while (tentativas < 3)
        {
            Console.Write("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe) (SIM/NAO): ");
            resposta[1] = Console.ReadLine()??"".Trim().ToUpper();

            if (resposta[1] == "SIM")
            {
                porcentagem += 30;
                break;
            }
            else if (resposta[1] == "NAO")
            {
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 'SIM' ou 'NAO'.");
                tentativas++;

                if (tentativas >= 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico.");
                    Console.WriteLine("Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Environment.Exit(0);
                }
            }
        }
        tentativas = 0;
        while (tentativas < 3)
        {
            Console.Write("Teve contato com pessoas com sintomas gripais nos últimos dias? (SIM/NAO): ");
            resposta[2] = Console.ReadLine()??"".Trim().ToUpper() ?? "";

            if (resposta[2] == "SIM")
            {
                porcentagem += 30;
                break;
            }
            else if (resposta[2] == "NAO")
            {
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 'SIM' ou 'NAO'.");
                tentativas++;

                if (tentativas >= 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico.");
                    Console.WriteLine("Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Environment.Exit(0);
                }
            }
        }
        tentativas = 0;
        while (tentativas < 3)
        {
            Console.Write("Está retornando de viagem realizada no exterior? (SIM/NAO): ");
            resposta[3] = Console.ReadLine()??"".Trim().ToUpper();

            if (resposta[3] == "SIM")
            {
                porcentagem += 30;
                Console.WriteLine("Você ficará sob observação por 05 dias.");
                break;
            }
            else if (resposta[3] == "NAO")
            {
                break;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 'SIM' ou 'NAO'.");
                tentativas++;

                if (tentativas >= 3)
                {
                    Console.WriteLine("Não foi possível realizar o diagnóstico.");
                    Console.WriteLine("Gentileza procurar ajuda médica caso apareça algum sintoma.");
                    Environment.Exit(0);
                }
            }
        }
        Console.WriteLine("\nDados da pessoa:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cartão de vacina em dia: {resposta[0]}");
        Console.WriteLine($"Teve sintomas recentemente: {resposta[1]}");
        Console.WriteLine($"Teve contato com pessoas com sintomas gripais: {resposta[2]}");
        Console.WriteLine($"Retornando de viagem realizada no exterior: {resposta[3]}");
        Console.WriteLine($"Probabilidade de estar infectado: {porcentagem}%");

        if (porcentagem <= 30)
        {
            Console.WriteLine("Orientação: Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.");
        }
        else if (porcentagem <= 60)
        {
            Console.WriteLine("Orientação: Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.");
        }
        else if (porcentagem <= 89)
        {
            Console.WriteLine("Orientação: Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.");
        }
        else
        {
            Console.WriteLine("Orientação: Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.");
        }
        Console.ReadLine();
    }
}