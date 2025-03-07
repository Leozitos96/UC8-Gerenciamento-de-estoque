﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static GerenciamentoDeEstoque.Program;

namespace GerenciamentoDeEstoque
{
    public partial class Cadastro : Form
    {
        Thread thread;
        private Database database = new Database();
        public Cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // CADASTRO
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // nome
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // caixa do nome
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // cpf
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // caixa do CPF
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // senha
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // caixa da senha
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // email
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // caixa do email
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cadastrar.
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirLogin(object obj)
        {
            Application.Run(new Login());
        }

        /*Fecha o form voltando para a tela de Login*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(AbrirLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBoxUsuario.Text.Trim();
            string senha = textBoxSenha.Text.Trim();
            string cargo = comboBox1.SelectedItem.ToString();
            string confirmarSenha = textBoxConfirmarSenha.Text.Trim();
            if (!(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha)))
            {
                if(!(senha != confirmarSenha))
                {
                    Usuario usuario = new Usuario(nome, cargo, senha);
                    database.CadastrarUsuario(usuario);
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Senhas divergentes!", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro");
            }
        }
    }
}

