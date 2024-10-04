public class Moto : Veiculo
{
    private bool TemBagageiro;

    public Moto(string marca, string modelo, int ano, bool TemBagageiro)
    :base(marca, modelo, ano)
    {
        this.TemBagageiro = TemBagageiro;
    }

    public void DarGrau()
    {
        Console.WriteLine("RANDANDANDNADNADNANDN PAPAPPAPAP");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca},\nmodelo: {modelo}\nAno: {ano}");
    }
}
