namespace Cadastro_de_produto
{
    public partial class Form1 : Form
    {
        List<Cadastro> produtos = new List<Cadastro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.Codigo = Convert.ToInt32(codigo.Text);
            c.Descricao = Convert.ToString(descricao.Text);
            c.ValorA = Convert.ToDouble(precoA.Text);
            c.Porcentagem = Convert.ToDouble(porcetagem.Text);

            double a = (c.ValorA * c.Porcentagem) / 100;
             c.ValorVenda = c.ValorA + a;
            label7.Text = $"R$ {c.ValorVenda.ToString("00.00")}";

            produtos.Add(c);
            lista.DataSource = null;
            lista.Refresh();
            lista.DataSource = produtos;

            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo.Clear();
            descricao.Clear();
            precoA.Clear();
            porcetagem.Clear();
        }
    }
}