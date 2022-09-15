using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void English_Click(object sender, EventArgs e)
        {
            Hello.Text = "English: Hello";
            SoundsLike.Text = "Sounds like: heh-low";
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            Hello.Text = "Russian: Привет";
            SoundsLike.Text = "Sounds like: pri-vet";
        }

        private void Estonian_Click(object sender, EventArgs e)
        {
            Hello.Text = "Estonian: Tere";
            SoundsLike.Text = "Sounds like: tehr-reh";
        }

        private void German_Click(object sender, EventArgs e)
        {
            Hello.Text = "German: Guten Tag";
            SoundsLike.Text = "Sounds like: goot-en tahk";
        }

        private void French_Click(object sender, EventArgs e)
        {
            Hello.Text = "French: Bonjour";
            SoundsLike.Text = "Sounds like: bohn-zhoohr";
        }

        private void Italian_Click(object sender, EventArgs e)
        {
            Hello.Text = "Italian: Salve";
            SoundsLike.Text = "Sounds like: sahl-veh";
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            Hello.Text = "Spanish: Hola";
            SoundsLike.Text = "Sounds like: oh-lah";
        }

        private void Portuguese_Click(object sender, EventArgs e)
        {
            Hello.Text = "Portuguese: Olá";
            SoundsLike.Text = "Sounds like: oh-lah";
        }

        private void Pronunciation_Click(object sender, EventArgs e)
        {
            SoundsLike.Visible = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            SoundsLike.Visible = false;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pavel Golovan 2022\n\nThis app allows you to learn how to say Hello in different languages.\nSimply select a flag from those available on the screen and the app will show you the word Hello in the selected language.\nYou can also show or hide the pronunciation of the word in the lower left corner of the app.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
