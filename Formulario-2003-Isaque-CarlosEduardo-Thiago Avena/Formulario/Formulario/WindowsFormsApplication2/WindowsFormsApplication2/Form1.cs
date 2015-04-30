using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2 {
    public partial class Class1: Form {
        List < Funcionario > quantidade = new List < Funcionario > ();
        List < string > funcionariosList = new List < string > ();
        int numFuncionarios = 0;
        int funcionarioCerto;
        bool func = false;
        string line;
        public Class1() {
            InitializeComponent();
            //MessageBox.Show("Instruçoes:"+ Environment.NewLine + "Olhe aki");
            pictureBox1.ImageLocation = @"F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\Formulario\Formulario\hue\WindowsFormsApplication2\Imagems\desconhecido.jpg";
            System.IO.StreamReader file = new System.IO.StreamReader(@"F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\WriteLines.txt");
            while ((line = file.ReadLine()) != null) {
                string[] info = line.Split('#');
                quantidade.Add(new Funcionario {
                    nome = info[0], idade = info[1], sexo = info[2], cargo = info[3], civil = info[10], email = info[5], endereco = info[7], filhos = info[6], salario = info[4], sangue = info[9], telefone = info[8], imagem = info[11]
                });
                funcionariosList.Add(info[0]);
                ver.Items.Add(info[0]);
                listBox1.Items.Add(info[0]);
                //pictureBox1.ImageLocation = (info[0]);
                numFuncionarios++;
            }
            file.Close();
        }
        public void addFuncionario() {
            quantidade.Add(new Funcionario {
                nome = nome.Text, idade = idade.Text, sexo = sexo.Text, sangue = sangue.Text, civil = civil.Text, cargo = cargo.Text, email = email.Text, endereco = endereco.Text, filhos = filhos.Text, telefone = telefone.Text, salario = salario.Text, imagem = pictureBox1.ImageLocation
            });
            funcionariosList.Add(nome.Text);
            ver.Items.Add(nome.Text);
            ver.AutoCompleteCustomSource.Add(nome.Text);
            //nome.AutoCompleteCustomSource.Add(nome.Text);
            numFuncionarios++;
        }
        //ADICIONAR FUNCIONÁRIOS
        private void button1_Click(object sender, EventArgs e) {
            bool existe = false;
            for (int i = 0; i < numFuncionarios; i++) {
                if (nome.Text == funcionariosList[i]) {
                    existe = true;
                    i = numFuncionarios;
                }
            }
            if (!existe) {
                if (nome.Text != "" && idade.Text != "" && sexo.Text != "" && sangue.Text != "" && civil.Text != "" && cargo.Text != "" && endereco.Text != "" && email.Text != "" && filhos.Text != "" && telefone.Text != "" && salario.Text != "" && pictureBox1.ImageLocation != null) {
                    addFuncionario();
                    MessageBox.Show("Funcionario adicionado.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nome.Text = "";
                    idade.Text = "";
                    sexo.SelectedIndex = -1;
                    sangue.SelectedIndex = -1;
                    civil.SelectedIndex = -1;
                    endereco.Text = "";
                    cargo.Text = "";
                    email.Text = "";
                    filhos.Text = "";
                    filhos.SelectedIndex = -1;
                    telefone.Text = "";
                    salario.SelectedIndex = -1;
                    textBox1.Text = "";
                    pictureBox1.ImageLocation = @"F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\Formulario\Formulario\hue\WindowsFormsApplication2\Imagems\desconhecido.jpg";
                } else {
                    MessageBox.Show("Preencha todos os dados antes de adicionar um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else {
                MessageBox.Show("Esse funcionário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //VER FUNCIONÁRIO
        private void button5_Click(object sender, EventArgs e) {
            if (ver.Text != "") {
                for (int i = 0; i < numFuncionarios; i++) {
                    if (funcionariosList[i] == ver.Text) {
                        funcionarioCerto = i;
                        i = numFuncionarios;
                        func = true;
                        lista.Items.Clear();
                    }
                }
                if (func) {
                    lista.Items.Add("Nome: " + quantidade[funcionarioCerto].nome);
                    lista.Items.Add("Idade: " + quantidade[funcionarioCerto].idade);
                    lista.Items.Add("Sexo: " + quantidade[funcionarioCerto].sexo);
                    lista.Items.Add("Cargo: " + quantidade[funcionarioCerto].cargo);
                    lista.Items.Add("Salário: " + quantidade[funcionarioCerto].salario);
                    lista.Items.Add("E-mail: " + quantidade[funcionarioCerto].email);
                    lista.Items.Add("Filhos: " + quantidade[funcionarioCerto].filhos);
                    lista.Items.Add("Endereço: " + quantidade[funcionarioCerto].endereco);
                    lista.Items.Add("Telefone: " + quantidade[funcionarioCerto].telefone);
                    lista.Items.Add("Tipo Sanguínio: " + quantidade[funcionarioCerto].sangue);
                    lista.Items.Add("Estado Civil: " + quantidade[funcionarioCerto].civil);
                    pictureBox2.ImageLocation = quantidade[funcionarioCerto].imagem;
                }
            } else {
                MessageBox.Show("Por Favor Selecione o Funcionário que deseja ver");
            }
        }
        //REMOVER FUNCIONÁRIO
        private void button6_Click(object sender, EventArgs e) {
            if (ver.Text != "") {
                DialogResult result1 = MessageBox.Show("Deseja realmente remover o funcionário" + ver.Text + "", "Remover", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes) {
                    for (int i = 0; i < numFuncionarios; i++) {
                        if (funcionariosList[i] == ver.Text) {
                            funcionarioCerto = i;
                            i = numFuncionarios;
                            if (func) {
                                lista.Items.Remove("Nome: " + quantidade[funcionarioCerto].nome);
                                lista.Items.Remove("Idade: " + quantidade[funcionarioCerto].idade);
                                lista.Items.Remove("Sexo: " + quantidade[funcionarioCerto].sexo);
                                lista.Items.Remove("Cargo: " + quantidade[funcionarioCerto].cargo);
                                lista.Items.Remove("Salário: " + quantidade[funcionarioCerto].salario);
                                lista.Items.Remove("E-mail: " + quantidade[funcionarioCerto].email);
                                lista.Items.Remove("Filhos: " + quantidade[funcionarioCerto].filhos);
                                lista.Items.Remove("Endereço: " + quantidade[funcionarioCerto].endereco);
                                lista.Items.Remove("Telefone: " + quantidade[funcionarioCerto].telefone);
                                lista.Items.Remove("Tipo Sanguínio: " + quantidade[funcionarioCerto].sangue);
                                lista.Items.Remove("Estado Civil: " + quantidade[funcionarioCerto].civil);
                                pictureBox2.ImageLocation = "" /*+  quantidade[funcionarioCerto].imagem*/
                                ;
                            }
                        }
                    }
                    quantidade.Remove(quantidade[funcionarioCerto]);
                    funcionariosList.Remove(ver.Text);
                    ver.Items.Remove(ver.Text);
                    numFuncionarios--;
                    MessageBox.Show("Funcionário removido com sucesso");
                    ver.Text = "";
                } else {}
            } else {
                MessageBox.Show("Selecione o funcionario que desejas remover", "Erro");
            }
        }
        //LIMPAR
        private void button3_Click(object sender, EventArgs e) {
            nome.Text = "";
            idade.Text = "";
            sexo.Text = "";
            cargo.Text = "";
            salario.Text = "";
            email.Text = "";
            //filhos.SelectedIndex = -1;
            filhos.Text = "";
            endereco.Text = "";
            telefone.Text = "";
            sangue.Text = "";
            civil.Text = "";
            pictureBox1.ImageLocation = @"F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\Formulario\Formulario\hue\WindowsFormsApplication2\Imagems\desconhecido.jpg";
            textBox1.Text = "";
        }
        //SALVAR FORMULÁRIO
        private void salvarFormulárioToolStripMenuItem_Click(object sender, EventArgs e) {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@" F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\WriteLines.txt");
            for (int i = 0; i < numFuncionarios; i++) {
                //string jarvan = quantidade[i].ToString();
                file.WriteLine(quantidade[i].asString());
                //file.WriteLine(quantidade[funcionarioCerto].asString());
            }
            file.Close();
            MessageBox.Show("Dados Salvos com Sucesso");
        }
        //INSERIR IMAGEM DO COMPUTADOR
        private void button4_Click(object sender, EventArgs e) {
            //MessageBox.Show("Procure Pegar Fotos de Pefil  (Você precisa adicionar as imagems na Pasta)  de dentro da Pasta #Imagens contida na Pasta da Aplicação, caso você queira usar a Aplicação em outra Máquina, pois ele não encontrará a imagem que estiver em uma pasta que não existe nas demais máquinas");
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                MessageBox.Show("Imagem Adicionada com sucesso");
                // pictureBox1.ImageLocation = textBox1.Text;
            }
            string destino = Path.Combine(@"F:\Formulario-2003-Isaque-CarlosEduardo-Thiago Avena\Formulario\Formulario\WindowsFormsApplication2\WindowsFormsApplication2\bin\Debug\folder\", Path.GetFileName(pictureBox1.ImageLocation));
            //File.Copy(pictureBox1.ImageLocation, destino);
            
        }
        //EDITAR
        private void button7_Click(object sender, EventArgs e)
        {
            if (ver.Text != "")
            {
                tabControl1.SelectedTab = tabPage1;
                for (int i = 0; i < numFuncionarios; i++)
                {
                    if (funcionariosList[i] == ver.Text)
                    {
                        funcionarioCerto = i;
                        i = numFuncionarios;
                        func = true;
                        lista.Items.Clear();
                        pictureBox2.ImageLocation = "";
                    }
                }
                if (func)
                {
                    nome.Text = quantidade[funcionarioCerto].nome;
                    idade.Text = quantidade[funcionarioCerto].idade;
                    sexo.Text = quantidade[funcionarioCerto].sexo;
                    cargo.Text = quantidade[funcionarioCerto].cargo;
                    salario.Text = quantidade[funcionarioCerto].salario;
                    email.Text = quantidade[funcionarioCerto].email;
                    filhos.Text = quantidade[funcionarioCerto].filhos;
                    endereco.Text = quantidade[funcionarioCerto].endereco;
                    telefone.Text = quantidade[funcionarioCerto].telefone;
                    sangue.Text = quantidade[funcionarioCerto].sangue;
                    civil.Text = quantidade[funcionarioCerto].civil;
                    pictureBox1.ImageLocation = quantidade[funcionarioCerto].imagem;
                    textBox1.Text = quantidade[funcionarioCerto].imagem;
                    //quantidade[funcionarioCerto] = new Funcionario { nome = nome.Text, idade = idade.Text, cargo = cargo.Text, civil = civil.SelectedItem.ToString(), email = email.Text, endereco = endereco.Text, filhos = filhos.SelectedItem.ToString(), salario = salario.SelectedItem.ToString(), sangue = sangue.SelectedItem.ToString(), sexo = sexo.SelectedItem.ToString(), telefone = telefone.Text, imagem = pictureBox1.ImageLocation };
                }
            }
            else {
                MessageBox.Show(" Por favor selecione o funcionário que deseja editar ");
            }
        }
        //SALVAR ALTERAÇÕES
        private void button2_Click(object sender, EventArgs e)
        {
            if (nome.Text != "" && idade.Text != "" && sexo.Text != "" && sangue.Text != "" && civil.Text != "" && cargo.Text != "" && endereco.Text != "" && email.Text != "" && filhos.Text != "" && telefone.Text != "" && salario.Text != "" && pictureBox1.ImageLocation != null)
            {
                tabControl1.SelectedTab = tabPage2;
            quantidade[funcionarioCerto] = new Funcionario
            {
                nome = nome.Text,
                idade = idade.Text,
                cargo = cargo.Text,
                civil = civil.Text,
                email = email.Text,
                endereco = endereco.Text,
                filhos = filhos.Text,
                salario = salario.Text,
                sangue = sangue.Text,
                sexo = sexo.Text,
                telefone = telefone.Text,
                imagem = pictureBox1.ImageLocation
            };
            MessageBox.Show(" Alterações foram salvas ");
            nome.Text = "";
            idade.Text = "";
            cargo.Text = "";
            civil.Text = "";
            email.Text = "";
            endereco.Text = "";
            filhos.Text = "";
            salario.Text = "";
            sangue.Text = "";
            sexo.Text = "";
            telefone.Text = "";
            textBox1.Text = "";
            pictureBox1.ImageLocation = @" F: \Formulario - 2003 - Isaque - CarlosEduardo - Thiago Avena\Formulario\Formulario\hue\WindowsFormsApplication2\Imagems\desconhecido.jpg "; 
        }
        else{
            MessageBox.Show("Por favor não deixe nenhum espaço em branco "); }
        }
        private void Class1_Load(object sender, EventArgs e)
        {
            // Create a new instance of the form.
            // Create two buttons to use as the accept and cancel buttons.
            // Set the text of button1 to "
           
        }
        public void imagem() { }

        private void idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void filhos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

       

       
        private void nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox1.ImageLocation = textBox1.Text;
            }
            else {
                MessageBox.Show(" Por favor insira o URL da imagem no[URL da imagem do Facebook]");
            }

        }

        public void  img() {

            string folder = @"
            folder "; 

           

            if (!Directory.Exists(folder))
            {

                Directory.CreateDirectory(folder);

            }
        }

       
    }
}