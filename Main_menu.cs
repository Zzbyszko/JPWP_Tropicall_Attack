using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_JPWP
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //przycisk nowa gra
        {
            // Tworzymy instancję drugiego okna
            New_game New_game = new New_game();

            // Pokazujemy drugie okno
            New_game.Show();

            // Opcjonalnie zamykamy pierwsze okno
            this.Hide(); // Ukrywa MainForm, ale go nie zamyka
            //this.Close(); // Jesli chcesz zamknąć MainForm
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //przycisk zakoncz gre
        {
            Application.Exit(); // Kończy działanie aplikacji
        }
    }
}
