using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarSoltarCeldasDgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridViewRow f1Dgv1 = (DataGridViewRow)dgv1.Rows[0].Clone();
            DataGridViewRow f2Dgv1 = (DataGridViewRow)dgv1.Rows[0].Clone();
            DataGridViewRow f3Dgv1 = (DataGridViewRow)dgv1.Rows[0].Clone();
            DataGridViewRow f4Dgv1 = (DataGridViewRow)dgv1.Rows[0].Clone();

            DataGridViewRow f1Dgv2 = (DataGridViewRow)dgv2.Rows[0].Clone();
            DataGridViewRow f2Dgv2 = (DataGridViewRow)dgv2.Rows[0].Clone();
            DataGridViewRow f3Dgv2 = (DataGridViewRow)dgv2.Rows[0].Clone();
            DataGridViewRow f4Dgv2 = (DataGridViewRow)dgv2.Rows[0].Clone();

            f1Dgv1.Cells[0].Value = "Pepe";
            dgv1.Rows.Add(f1Dgv1);
            f2Dgv1.Cells[0].Value = "Maria";
            dgv1.Rows.Add(f2Dgv1);
            f3Dgv1.Cells[0].Value = "Carlos";
            dgv1.Rows.Add(f3Dgv1);
            f4Dgv1.Cells[0].Value = "Valeria";
            dgv1.Rows.Add(f4Dgv1);

            f1Dgv2.Cells[0].Value = "";
            dgv2.Rows.Add(f1Dgv2);
            f2Dgv2.Cells[0].Value = "";
            dgv2.Rows.Add(f2Dgv2);
            f3Dgv2.Cells[0].Value = "";
            dgv2.Rows.Add(f3Dgv2);
            f4Dgv2.Cells[0].Value = "";
            dgv2.Rows.Add(f4Dgv2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nos permite arrastrar la foto al otro pictureBox
            this.dgv1.AllowDrop = true;
            this.dgv2.AllowDrop = true;
            //Le asignamos que haga lo mismo que el evento que tiene entre parentesis
            dgv1.CellMouseDown += new DataGridViewCellMouseEventHandler(dgv2_CellMouseDown);
            dgv1.DragEnter += new DragEventHandler(dgv2_DragEnter);
            dgv1.DragDrop += new DragEventHandler(dgv2_DragDrop);
        }
        //Se produce cuando presionamos el boton izquierdo del raton en una celda
        private void dgv2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Guardamos en una variable la fila que hemos cogido con el raton
            int filaCogida = e.RowIndex;
            //Guardamos en una variable la columna que hemos cogido con el raton
            int columnaCogida = e.ColumnIndex;
            //Guardamos en un datagridview la fila y la columna cogida con el raton
            DataGridView dgv = (DataGridView)sender;
            dgv.DoDragDrop(dgv.Rows[filaCogida].Cells[columnaCogida].Value.ToString(), DragDropEffects.Copy);
        }
        //Se produce cuando se arrastra la celda dentro del datagridview
        private void dgv2_DragEnter(object sender, DragEventArgs e)
        {
            //Si hay una celda se copia en el segundo datagridview y si no pues no
            DataGridView dgv = (DataGridView)sender;
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //Se produce cuando se inicia una operacion de arrastrar y colocar
        private void dgv2_DragDrop(object sender, DragEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Point clientPoint = dgv2.PointToClient(new Point(e.X, e.Y));

            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dgv2.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1
                    && hittest.RowIndex != -1)
                    dgv2[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;

            }
        }
    }
}
