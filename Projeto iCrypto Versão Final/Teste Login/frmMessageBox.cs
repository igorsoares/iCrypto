﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login.Properties;

namespace Teste_Login
{
    public partial class frmMessageBox : Form
    {
        bool YesNo = false;
        string simNao = "closed";
        public frmMessageBox(string icon, string texto, string titulo, bool DarkTheme, bool botaoYesNo)
        {
            InitializeComponent();

            btn2.Hide();
            btn2.Enabled = false;

            if (botaoYesNo)
            {
                btn2.Focus();
                btn1.Text = "Não";
                btn2.Text = "Sim";
                btn2.Show();
                btn2.Enabled = true;
                YesNo = true;
            }

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }

            switch (icon.ToLower())
            {
                case "warning":
                    picIcon.Image = DarkTheme ? Resources.DarkWarning : Resources.Warning; 
                    break;

                case "question":
                    picIcon.Image = DarkTheme ? Resources.DarkQuestion : Resources.Question;
                    break;

                case "information":
                    picIcon.Image = DarkTheme ? Resources.DarkInformation : Resources.Information;
                    break;

                case "correct":
                    picIcon.Image = DarkTheme ? Resources.DarkCorrect : Resources.Correct;
                    break;

                case "error":
                    picIcon.Image = DarkTheme ? Resources.DarkError : Resources.Error;
                    break;

                case "null":
                    picIcon.Hide();
                    this.Width -= 55;
                    lbTexto.Location = new Point(20, 35);
                    break;
            } 

            lbTexto.Text = texto;
            this.Text = titulo;

            if (lbTexto.Width > 178)
            {
                this.Width += lbTexto.Width - 178;
            }

            if (lbTexto.Height > 13)
            {
                this.Height += lbTexto.Height - 13;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!YesNo)
            {
                this.Close();
            }
            else
            {
                simNao = "nao";
                this.Close();
            }
        }

        public string retornaYesNo()
        {
            return simNao;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            simNao = "sim";
            this.Close();
        }
    }
}
