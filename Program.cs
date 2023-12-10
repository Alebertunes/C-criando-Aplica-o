//Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string>{"U2", "The beatles", "Bon Jovi"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());





void ExibirLogo()
{
    Console.WriteLine(@"
    
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Difiye -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida =  Console.ReadLine()!; /*! significa que não pode ser nulo*/
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); /* O parse converte o texto para o int*/
    
    switch(opcaoEscolhidaNumerica){
        case 1: RegistrarBanda();
        break;
        case 2: MostraBandasRegistradas();
        break;
        case 3: AvaliarUmaBanda();
        break;
        case 4: ImprimirMediaBanda();
        break;
        case -1: Console.WriteLine("Tchau Tchau :)");
        break;
        default: Console.WriteLine("Opção invalida");
        break;
    }
}

void RegistrarBanda()
{
    
    Console.Clear();
    ExibirTituloDaOpcao("Registros das bandas");
    Console.WriteLine("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void MostraBandasRegistradas(){
    Console.Clear();

    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    // for(int i = 0; i < ListaDasBandas.Count; i++){
    //     Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    // }

    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{

    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco);
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeDaBanda)){

        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }else{
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para coltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}


void ImprimirMediaBanda()
{
    ExibirTituloDaOpcao("Media da banda");

    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string bandaDigitada = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(bandaDigitada)){

    double mediaBanda = bandasRegistradas[bandaDigitada].Average();
    Console.WriteLine($"\nA media da banda {bandaDigitada} é {mediaBanda}");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
    
    }else{
        Console.WriteLine("Banda Digitada não encontrada");
        Console.WriteLine("Digite uma tecla para coltar ao menu");
        Console.ReadKey();
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

 

}

ExibirOpcoesDoMenu();






