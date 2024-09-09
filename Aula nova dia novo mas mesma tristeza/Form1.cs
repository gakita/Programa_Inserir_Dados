namespace Aula_nova_dia_novo_mas_mesma_tristeza
{
    public partial class Form1 : Form
    {
        struct DadosPessoais
        {
            public string nome, email, telefone;
        }

        DadosPessoais[] cadastro = new DadosPessoais[1000];

        int cont = 0, contCadastro;


        public Form1()
        {
            InitializeComponent();

            cadastro[0].nome = "gertrudes"; cadastro[0].email = "gertrudes@gmail.com"; cadastro[0].telefone = "(19)97722-2222";
            cadastro[1].nome = "Vasco"; cadastro[1].email = "Vascodagama@gmail.com"; cadastro[1].telefone = "43435354352";
            cadastro[2].nome = "Pedro"; cadastro[2].email = "Pedro@gmail.com"; cadastro[2].telefone = "4124155212";
            cadastro[3].nome = "Diabetes da Silva"; cadastro[3].email = "marcospastoreiodasilva@gmail.com"; cadastro[3].telefone = "4241243242";

            contCadastro = 4;

            lbxCadastros.Items.Clear();

            while (cont < contCadastro)
            {
                string aux = cadastro[cont].nome + "\t" + cadastro[cont].email + "\t" + cadastro[cont].telefone;
                lbxCadastros.Items.Add(aux);
                cont++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastro[contCadastro].nome = tbxNome.Text;
            cadastro[contCadastro].email = tbxEmail.Text;
            cadastro[contCadastro].telefone = tbxTelefone.Text;
            contCadastro++;
            string aux = tbxNome.Text + "\t" + tbxEmail.Text + "\t" + tbxTelefone.Text;
            lbxCadastros.Items.Add(aux);
            tbxNome.Clear();
            tbxEmail.Clear();
            tbxTelefone.Clear();
        }

        private void btnConsultarNome_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            tbxNome.Text = "";
            tbxEmail.Text = "";
            tbxTelefone.Text = "";

            for (int i = 0; i < contCadastro; i++)
            {
                if (cadastro[i].nome == nome)
                {
                    tbxNome.Text = cadastro[i].nome;
                    tbxEmail.Text = cadastro[i].email;
                    tbxTelefone.Text = cadastro[i].telefone;
                    break;
                }
            }
        }

        private void bntConsultarEmail_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            tbxNome.Text = "";
            tbxEmail.Text = "";
            tbxTelefone.Text = "";

            for (int i = 0; i < contCadastro; i++)
            {
                if (cadastro[i].email == email)
                {
                    tbxNome.Text = cadastro[i].nome;
                    tbxEmail.Text = cadastro[i].email;
                    tbxTelefone.Text = cadastro[i].telefone;
                    break;
                }
            }

        }

        private void btnConsultarTel_Click(object sender, EventArgs e)
        {
            string telefone = tbxTelefone.Text;
            tbxNome.Text = "";
            tbxEmail.Text = "";
            tbxTelefone.Text = "";

            for (int i = 0; i < contCadastro; i++)
            {
                if (cadastro[i].telefone == telefone)
                {
                    tbxNome.Text = cadastro[i].nome;
                    tbxEmail.Text = cadastro[i].email;
                    tbxTelefone.Text = cadastro[i].telefone;
                    break;
                }
            }
        }
    }
}
