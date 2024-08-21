internal class Program
{
    private static void Main(string[] args)
    {
        //Trabalhando com lista ( LIST )
        //Criando uma lista
        List<string> frutas = new List<string>();
        //adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");
        //imprimir os itens da lista


        frutas.ForEach(Console.WriteLine);


        Console.WriteLine();//Pula linha em branco

        //Imprimir elemento na posição especifica
        Console.WriteLine("Fruta na indice 2 : " + frutas[2]);

        //Inserir um elmento no indice específico
        frutas.Insert(1, "Maracuja");


        Console.WriteLine();//Pula linha em branco

        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();//Pula linha em branco

        //Alterar um elmento no indice especifico
        frutas[4] = "Pêra";
        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();//Pula linha em branco

        //Remove o elemento da lista
        frutas.RemoveAt(3);

        //Remove o elemento pelo valor do conteudo
        frutas.Remove("Morango");

        //Imprimir a lista novamente
        Console.WriteLine();
        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);
        //Apagar todos os elementos da lista
        frutas.Clear();

        //TRABALHANDO COM DICIONARIOS DE DADOS

        //Criando um dicionario de dados

        Dictionary<int, string> carros = new Dictionary<int, string>();
        //Adicionar Dados a um Dicionario
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");//diferente da lista que o indice é automatico
        carros.Add(2, "Ford ka");

        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine("Meu Dicionario de carros : ");
        //Imprimir um dicionario de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();

        //TRABALHANDO COM FILA

        //criar uma lista (Queue)-fila
        Queue<string> filaBanco = new Queue<string>();

        //Adicionar Elementos em uma Fila
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Mariana");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine("=======================================================");
        Console.WriteLine();

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        bool achou = filaBanco.Contains("Bia");

        if (achou == true)
        {
            Console.WriteLine("A Pessoa esta na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não esta na fila");
        }
        Console.WriteLine();
        Console.WriteLine("=======================================================");
        Console.WriteLine();

        //TRABALHANDO COM PILHA (STRACK)
        //Criando uma Pilha
        Stack<string> livros = new Stack<string>();

        //Adicionar elementos em uma pilha

        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de neve e os sete anões");
        livros.Push("Princesa e o sapo");

        foreach (var livro in livros)
        {

            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("=======================================================");
        Console.WriteLine();

        //Remove o primeiro elemento da Pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
        Console.WriteLine("=======================================================");
        Console.WriteLine();



    }
}