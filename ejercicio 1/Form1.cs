using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        List<lista> datos = new List<lista>();
        public void guardardato()
        {
            lista lista1 = new lista(Txt_Nombre.Text);

            datos.Add(lista1);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datos;

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            guardardato();
        }
    }
}
