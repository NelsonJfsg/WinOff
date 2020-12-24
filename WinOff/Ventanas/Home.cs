using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOff.Ventanas {

    public partial class Home : Form {


        //Variables globales.
        bool estado = false;
        String unidad;
        int tiempo;

        //Constructor.
        public Home() {
            InitializeComponent();
        }

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Evento load del Form principal para cargar la cantidad de tiempo.
        private void Home_Load(object sender, EventArgs e) {

            //Variables
            int i = 1;

            //Llenamos el CB con los numeros del 1 al 60.
            do {

                cbTiempo.Items.Add(i);
                i++;

            } while(i <= 60);

        }

        //Evento click para programar el apagado.
        private void butApagar_Click(object sender, EventArgs e) {

            //Variables
            unidad = obtenerUnidad(unidad, gbUnidad);
            
            //Verificamos que el tiempo sea valido.
            try {
                tiempo = int.Parse(cbTiempo.Text);
            } catch (Exception err) {
                MessageBox.Show("Cantidad de tiempo invalida.");
                return;
            }

            //Posibles casos.
            if (unidad == "Segundos.") {
                programarApagado(tiempo);
            } else {
                if (unidad == "Minutos.") {
                    tiempo = tiempo * 60;
                    programarApagado(tiempo);
                } else {
                    if (unidad == "Horas.") {
                        tiempo = tiempo * 3600;
                        programarApagado(tiempo);
                    } else {
                        MessageBox.Show("Seleccione alguna unidad de tiempo valida.");
                    }
                }
            }

            //Cambiamos el estado a verdadero.
            estado = true;

        }

        //Evento click para cancelar el apagado.
        private void butCancelar_Click(object sender, EventArgs e) {

            System.Diagnostics.Process.Start("Shutdown", "/a");

            if (estado == true) {
                MessageBox.Show("Apagado cancelado.");
            } else {
                MessageBox.Show("No se a programado ningun apagado.");
            }
            
            estado = false;
            
        }

        //Metodo para obtener la unidad seleccionada.
        private String obtenerUnidad(String unidad, GroupBox groupBox) {

            //Validar tiempo.
            foreach (RadioButton rb in groupBox.Controls) {

                //Obtenemos el rb seleccionado.
                if (rb.Checked) {

                    //Asignamos la unidad a la variable.
                    unidad = rb.Text;

                }

            }

            return unidad;

        }

        //Metodo para programar el apagado.
        private void programarApagado(int tiempo) {
            System.Diagnostics.Process.Start("Shutdown", "-s -t " + tiempo);
        }

    }
}
