namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "antonny";
            string senha = "@1234";

            if (usuario == txtUsuario.Text && senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double numero = 10;
            lsbMostra.Items.Clear();

            while (numero <= 100 & numero >= 1)
            {
                numero ++;
                lsbMostra.Items.Add(numero.ToString());
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            int num = 100;
            do
            {
                num *= 2;
                lsbMostra.Items.Add(num);

            } while (num < 1000);


        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int numfor = 0;
            lsbMostra.Items.Clear();

            for (numfor = 1; numfor <= 250; numfor *= 2)
            {
                lsbMostra.Items.Add(numfor.ToString());
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // Array ou vetor é uma estrutura de dados que armazena
            // valores que podem ser acessados por uma posição
            // frutas[0] = "Maça", frutas[1] = "Mamão",.....

            lsbMostra.Items.Clear();
            //lsbMostra.Items.Add(frutas[0]);
            //lsbMostra.Items.Add(frutas[1]);

            string[] compras = ["Sal grosso", "Arroz", "Picanha", "Limão"];

            string produto = txtRepeticao.Text;

            foreach (string lista in compras)
            {
                if (produto == "completo")
                {
                    lsbMostra.Items.Add(lista);
                }
                else if(produto == "1")
                {
                    lsbMostra.Items.Add(compras[0]);
                }
                else if (produto == "2")
                {
                    lsbMostra.Items.Add(compras[1]);
                }
                else if (produto == "3")
                {
                    lsbMostra.Items.Add(compras[2]);
                }
                else if (produto == "4")
                {
                    lsbMostra.Items.Add(compras[3]);
                }
                else
                {
                    lsbMostra.Items.Add("Escreva se quer a lista completa ou algum dos 4 itens");
                }

            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int cont = 10;
            lsbMostra.Items.Clear();

            while (cont <= 200 & cont >= 1)
            {
                cont = cont + cont;
                if (cont == 100)
                {
                    break;
                }
                lsbMostra.Items.Add(cont.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int conta = 50;
            lsbMostra.Items.Clear();

            while (conta <= 1000 & conta >= 1)
            {
                conta = (conta + conta) * 3;

                if (conta == 300)
                {
                    continue;
                }
                lsbMostra.Items.Add(conta);
            }
        }
    }
}
