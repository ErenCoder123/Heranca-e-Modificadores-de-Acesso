public class Carro: Veiculo
{
    private int numDePortas;

    public Carro(string marca,string modelo, int ano,int numDePortas):base(marca,modelo,ano)
    {
        this.numDePortas = numDePortas;
    }


    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }
    public void ExibirInformacoes(){
        Console.WriteLine($"marca: {marca}\nmodelo :{modelo}\nano: {ano}\nnumero de portas : {numDePortas} ");
    }
}