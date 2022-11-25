using DesafioBanco;

string mensagem = "";

try
{
    Console.WriteLine("Bem vindo ao cadastro de contas bancárias");

    List<ContaBancaria> listacontas = new List<ContaBancaria>();

    for (int contagem = 1; contagem <= 3 ; contagem++)
    {
        Console.WriteLine("Cadastre uma nova conta");

        Console.WriteLine($"Digite o tipo da conta{contagem}: ");
        string tipoconta = Console.ReadLine();

        Console.WriteLine($"Digite a agencia {contagem}: ");
        int agencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o número da conta {contagem}: ");
        int numeroconta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o saldo {contagem}:");
        double saldoconta = Convert.ToDouble(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(tipoconta, numeroconta, agencia, saldoconta);

        listacontas.Add(contaBancaria);

    }

    Console.WriteLine("Qual o numero de conta voce deseja ver? ");
    int numerodecontabusca = Convert.ToInt32(Console.ReadLine());

    if(listacontas.Where(conta => conta.Numero == numerodecontabusca).Any())
    {
        ContaBancaria contaBancariaBusca = listacontas.Where(conta => conta.Numero == numerodecontabusca).FirstOrDefault();
        mensagem = contaBancariaBusca.ExibirDadosConta();
    }
    else
    {
        mensagem = ("Essa conta não existe");
    }



}
catch(Exception e)
{
    mensagem = "Aconteceu um erro no sistema: " + e.Message;
}
finally
{
    Console.WriteLine(mensagem);
}




