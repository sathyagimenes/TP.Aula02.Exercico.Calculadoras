using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSimples_Click(object sender, EventArgs e)
        {
            CalculadoraSimples telaSimples = new CalculadoraSimples();
            telaSimples.ShowDialog();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            CalculadoraIMC telaIMC = new CalculadoraIMC();
            telaIMC.ShowDialog();
        }
    }
}
