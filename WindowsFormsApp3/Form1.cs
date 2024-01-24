using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        CustomerController controlador = new CustomerController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar_grilla();
        }

        private void Cargar_grilla()
        {
            DataTable dt = new DataTable();

            dt = controlador.mostrarventas();
            
            grilla.DataSource = controlador.mostrarventas();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad =150;
            int almacen = 100; 


            if(cantidad >= almacen)
            {
                grilla.RowsDefaultCellStyle.BackColor = Color.Yellow;

            }else
            {
                grilla.RowsDefaultCellStyle.BackColor = Color.Red;
            }


            //grilla.RowsDefaultCellStyle.BackColor = Color.Yellow;
            //grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;

            
        }

       
    }
}
