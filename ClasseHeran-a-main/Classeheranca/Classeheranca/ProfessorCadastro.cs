using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classeheranca
{
    public partial class ProfessorCadastro : Form
    {
        Professor professor;
        public ProfessorCadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados());
        }

        private void ProfessorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            professor = new Professor(textBox1.Text, (Convert.ToInt32(textBox2.Text)), textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
