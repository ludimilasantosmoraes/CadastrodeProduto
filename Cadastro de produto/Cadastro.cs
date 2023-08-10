public class Cadastro
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public double ValorA { get; set; }
    public double Porcentagem { get; set; }
    public double ValorVenda { get; set; }

    public Cadastro()
    {

    }
    public Cadastro(int codigo, string descricao, double valorA, double porcentagem, double valorVenda)

    {
        this.Codigo = codigo;
        this.Descricao = descricao;
        this.ValorA = valorA;
        this.Porcentagem = porcentagem;
        this.ValorVenda = valorVenda;
    }
   
}
 