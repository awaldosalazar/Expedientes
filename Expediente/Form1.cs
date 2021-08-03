using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Expediente
{
    public partial class Form1 : Form
    {
        String[] directorios;
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\WALDO\Documents\UNIVERSIDAD\4to Semestre\Seminario de Algoritmia\Expediente\Expedientes");

        /***************************************[*ARBOL BINARIO*]*************************************************/
        class Nodo
        {
            public int datoAlmacenar;
            public Nodo izq, der;
        }
        Nodo raiz;
        
        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.datoAlmacenar = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, actual;
                actual = raiz;
                while (actual != null)
                {
                    anterior = actual;
                    if (info < actual.datoAlmacenar)
                        actual = actual.izq;
                    else
                        actual = actual.der;
                }
                if (info < anterior.datoAlmacenar)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirPre(Nodo actual)
        {
            if (actual != null)
            {
                richTextBoxArbol.Text += actual.datoAlmacenar + " ";
                ImprimirPre(actual.izq);
                ImprimirPre(actual.der);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
        }
        
        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
        }
        
        public void ImprimirPost()
        {
            ImprimirPost(raiz);
        }
        
        private void ImprimirEntre(Nodo actual)
        {
            if (actual != null)
            {
                ImprimirEntre(actual.izq);
                richTextBoxArbol.Text += actual.datoAlmacenar + " ";
                ImprimirEntre(actual.der);
            }
        }

       


        private void ImprimirPost(Nodo actual)
        {
            if (actual != null)
            {
                ImprimirPost(actual.izq);
                ImprimirPost(actual.der);
                richTextBoxArbol.Text += actual.datoAlmacenar + " ";
            }
        }


        /*********************************************************************************************************/
        int encontradoBuscar = 0;
        private void buscarABB(int dato,Nodo ABB)
        {
            if (ABB == null)
            {
                MessageBox.Show("ARBOL VACIO");
                return;
            }
            if (ABB.datoAlmacenar == dato)
            {
                encontradoBuscar = 1;
                return;
            }
            if (ABB.datoAlmacenar > dato)
            {
                buscarABB(dato, ABB.izq);
            }
            if (ABB.datoAlmacenar < dato)
            {
                buscarABB(dato, ABB.der);
            }
        }

        public int buscar(int dato)
        {
            buscarABB(dato,raiz);
            if(encontradoBuscar == 1)
            {
                encontradoBuscar = 0;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /***************************************[*ARBOL BINARIO*]*************************************************/


        public Form1()
        {
            InitializeComponent();
            cargar();
            raiz = null;
            richTextBoxArbol.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas guardar el expedicente?", this.Text, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)

            {
                try
                {
                    System.IO.File.WriteAllText(di.FullName + @"\" + textBoxNombre.Text + ".txt",textBoxEdad.Text + "\n" + richTextBoxAntecedentes.Text);
                    cargar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            Boolean band = false;
            String Nombre = textBoxNombre.Text;
            limpear();
            foreach (var i in directorios)
            {
                if (i.ToString() == Nombre + ".txt")
                {
                    textBoxEdad.ReadOnly = true;
                    richTextBoxAntecedentes.ReadOnly = true;
                    buttonAgregar.Visible = false;
                    buttonNuevo.Visible = true;
                    band = true;
                    string[] lines = System.IO.File.ReadAllLines(di.FullName + @"\" + Nombre + ".txt");
                    textBoxNombre.Text = Nombre;
                    textBoxEdad.Text = lines[0];
                    for(int j = 1;j < lines.Length;j++)
                    {
                        richTextBoxAntecedentes.Text += lines[j] + "\n";
                    }
                }
            }
            if(band == false)
            {
                MessageBox.Show("NO SE ENCONTRO NINGUN EXPEDIENTE");
            }
            band = false;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpear();
            textBoxEdad.ReadOnly = false;
            richTextBoxAntecedentes.ReadOnly = false;
            buttonAgregar.Visible = true;
            buttonNuevo.Visible = false;
        }
        int encontrado = 0;
        String nombrePasiente;
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            cargar();
            textBoxNombre2.Text = "";
            textBoxEdad2.Text = "";
            richTextBoxDes.Clear();
               foreach (DataGridViewRow Row in dataGridViewArbol.Rows)
               {
                    string Valor = Convert.ToString(Row.Cells["Nombre"].Value);

                    if (Valor == this.textBoxExpedienteBuscar.Text)
                    {
                        int resultadoInt = Convert.ToInt32(Row.Cells["Valor"].Value);
                        nombrePasiente = Convert.ToString(Row.Cells["Nombre"].Value);
                        
                        encontrado = buscar(resultadoInt);
                    }
               }
            if(encontrado == 1)
            {
                string[] lines = System.IO.File.ReadAllLines(di.FullName + @"\" + nombrePasiente + ".txt");
                textBoxNombre2.Text = nombrePasiente;
                try
                {
                    textBoxEdad2.Text = lines[0];
                    for (int j = 1; j < lines.Length; j++)
                    {
                        richTextBoxDes.Text += lines[j] + "\n";
                    }
                }
                catch (Exception)
                {
                }
            }
            if (encontrado == 0)
            {
                MessageBox.Show("NO SE ENCONTRO NINGUN EXPEDIENTE");
            }
            encontrado = 0;
            /********************************/
        }

        private void limpear()
        {
            textBoxNombre.Text = "";
            richTextBoxAntecedentes.Text = "";
            textBoxEdad.Text = "";
        }
        public String[] cargaDirectorio()
        {
            List<String> archivos = new List<string>();
            foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            {
                archivos.Add(fi.Name);
            }
            return archivos.ToArray();
        }

        private void cargar()
        {
            richTextBoxArbol.Text = "";
            foreach (DataGridViewRow dgvRenglon in dataGridViewArbol.Rows)
                dataGridViewArbol.Rows.Clear();

            directorios = cargaDirectorio();
            for (int i = 0; i < directorios.Length; i++)
            {
                string nombre = directorios[i];
                string nombreSin = null;
                int numValor = 0;
                for (int j = 0; j < nombre.Length; j++)
                {
                    if (nombre[j] != '.')
                    {
                        nombreSin += nombre[j];
                        numValor += Convert.ToInt32(nombreSin[j]);
                    }
                    else
                    {
                        Insertar(numValor);
                        break;
                    }
                }
                String valorInt = numValor + "";
                dataGridViewArbol.Rows.Add(nombreSin,valorInt);
            }
           // ImprimirPre();
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            ImprimirPre();
        }

        private void buttoin_Click(object sender, EventArgs e)
        {
            ImprimirEntre();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            ImprimirPost();
        }
    }
}
