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
    public partial class New_game : Form
    {
        public New_game()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tworzymy instancję pierwszego okna
            Main_menu Main_menu = new Main_menu();

            // Pokazujemy pierwsze okno
            Main_menu.Show();

            // Zamykamy bieżące okno (SecondForm)
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instancja 3 okna 
            Phase1_easy Phase1 = new Phase1_easy();

            Phase1.Show();

            this.Hide();
        }
    }
}
