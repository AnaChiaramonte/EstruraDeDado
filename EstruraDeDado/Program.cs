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
        frutas.Add("Uva");
        frutas.Add("Goiaba");
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



        //Alterar um elmento no indice especifico
        frutas[4] = "Pêra";
        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);

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


    }
}