using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_3_A.S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creando variables globales
        String[] vNombre;
        String[] vCorreos;
        String[] vEndulzada;
        String[] vRegalo;
        String nombres;
        String correos;
        String endulzada;
        String regalo;

        //funcion que recibe nombres y los almacena en un vector por medio de la herramienta visual basic e input box
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCantJugador.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad de jugadores " +
                    "en el espacio designado");
            }

            else
            {
                int cantJugadores;
               

                cantJugadores = Convert.ToInt32(txtCantJugador.Text);
                if (cantJugadores < 2 || cantJugadores % 2 != 0)
                {
                    MessageBox.Show("Por favor ingrese un numero mayor o igual que 2 y que sea par ");
                }
                else
                {
                    vNombre = new String[cantJugadores];
                    for (int jugador = 1; jugador <= cantJugadores; jugador++)
                    {
                        nombres = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del jugador " + jugador, "Jugadores");
                        vNombre[jugador - 1] = nombres;
                    }
                }
            }
        }

        //funcion que recibe correos y los almacena en un vector por medio de la herramienta visual basic e input box
        private void btnIngresarCorreos_Click(object sender, EventArgs e)
        {
            if (txtCantJugador.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad de jugadores " +
                    "en el espacio designado");
            }
            else
            {
                int cantJugadores;
                cantJugadores = Convert.ToInt32(txtCantJugador.Text);
                if (cantJugadores < 2 || cantJugadores % 2 != 0)
                {
                    MessageBox.Show("Por favor ingrese un numero mayor o igual que 2 y que sea par ");
                }
                else
                {
                    vCorreos = new String[cantJugadores];
                    for (int jugador = 1; jugador <= cantJugadores; jugador++)
                    {
                        correos = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el correo del jugador " + jugador, "Correos");
                        vCorreos[jugador - 1] = correos;
                    }
                }
            }
        }

        //funcion que recibe la endulzada que quiere el usuario y los almacena en un vector por medio
        //de la herramienta visual basic e input box
        private void btnIngresarEndulzada_Click(object sender, EventArgs e)
        {
            if (txtCantJugador.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad de jugadores " +
                    "en el espacio designado");
            }
            else
            {
                int cantJugadores;
                cantJugadores = Convert.ToInt32(txtCantJugador.Text);
                if (cantJugadores < 2 || cantJugadores % 2 != 0)
                {
                    MessageBox.Show("Por favor ingrese un numero mayor o igual que 2 y que sea par ");
                }
                else
                {
                    vEndulzada = new String[cantJugadores];
                    for (int jugador = 1; jugador <= cantJugadores; jugador++)
                    {
                        endulzada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la endulzada deseada del jugador " + jugador, "Endulzadas");
                        vEndulzada[jugador - 1] = endulzada;
                    }
                }
            }
        }

        //funcion que recibe el regalo deseado por el usuario y lo almacena en un vector por medio
        //de la herramienta visual basic e input box
        private void btnIngresarRegalo_Click(object sender, EventArgs e)
        {
            if (txtCantJugador.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad de jugadores " +
                    "en el espacio designado");
            }
            else
            {
                int cantJugadores;
                cantJugadores = Convert.ToInt32(txtCantJugador.Text);
                if (cantJugadores < 2 || cantJugadores % 2 != 0)
                {
                    MessageBox.Show("Por favor ingrese un numero mayor o igual que 2 y que sea par ");
                }
                else
                {
                    vRegalo = new String[cantJugadores];
                    for (int jugador = 1; jugador <= cantJugadores; jugador++)
                    {
                        regalo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el regalo que desea el jugador " + jugador, "Regalos");
                        vRegalo[jugador - 1] = regalo;
                    }
                }
            }
        }

        //funcion que recolecta datos de varios vectores y muestra en pantalla
        //la informacion recopilada de las funciones anteriores
        private void btnInfJugador_Click(object sender, EventArgs e)
        {
            lbInfJugador.Items.Clear();
            int cantJugadores;
            cantJugadores = Convert.ToInt32(txtCantJugador.Text);
            for (int i = 1; i <= cantJugadores; i++)
            {
                lbInfJugador.Items.Add("Jugador  :" + i + "  -  " + vNombre[i - 1] + " Su endulzada favorita es:  " + vEndulzada[i - 1] + " y quiere de regalo: " + vRegalo[i - 1]);
            }
        }

        //funcion que asigna a cada uno de los participantes un amigo secreto 
        //y envia mediante un mensaje de simulacion la informacion del juego 
        private void btnAmigoSecreto_Click(object sender, EventArgs e)
        {
            lbInfJugador.Items.Clear();
            int cantJugadores;
            cantJugadores = Convert.ToInt32(txtCantJugador.Text);
            Random rnd = new Random();
            int valorEndulzada;  
            valorEndulzada = Convert.ToInt32(txtVendulzada.Text);
            int valorRegalo;
            valorRegalo = Convert.ToInt32(txtVregalo.Text);
            List<string> listaNombres = new List<string>(vNombre);
            List<string> amigoSecreto = new List<string>(listaNombres);

            for (int i = 0; i < listaNombres.Count; i++)
            {
                int indiceAleatorio = rnd.Next(amigoSecreto.Count);
                if (amigoSecreto[indiceAleatorio] == listaNombres[i])
                {
                    if (amigoSecreto.Count == 1)
                    {
                        MessageBox.Show("no se puede generar el amigo secreto, intenta de nuevo");
                        return;
                    }
                    else
                    {
                        do
                        {
                            indiceAleatorio = rnd.Next(amigoSecreto.Count);
                        } while (amigoSecreto[indiceAleatorio] == listaNombres[i]);
                    }
                }
                string asignación = $"Para:   {vCorreos[i]}  " +
                    $"\n Hola querid@  {listaNombres[i]} tu amigo secreto es : {amigoSecreto[indiceAleatorio]} recuerda " +
                    $"que el valor de la endulzada es {valorEndulzada} y el valor del regalo es {valorRegalo}";
                amigoSecreto.RemoveAt(indiceAleatorio);

                lbInfJugador.Items.Add(asignación);
            }
        }

        //funcion que calcula cuantos dias faltan para la proxima endulzada respecto a un afecha que ingrese el ususario
        private int CalcularDiasParaProximaEndulzada(DateTime fechaInicio, DateTime fechaFin, DateTime fechaX, int frecuencia)
        {
            if (fechaInicio <= fechaFin && frecuencia > 0)
            {
                if (fechaX >= fechaInicio && fechaX <= fechaFin)
                {
                    TimeSpan diferencia = fechaX - fechaInicio;
                    int diasTranscurridos = diferencia.Days;
                    int diasHastaProximaEndulzada = frecuencia - (diasTranscurridos % frecuencia);
                    return diasHastaProximaEndulzada;
                }
                else
                {
                    throw new ArgumentException("La fecha debe estar dentro del rango de fechas del juego.");
                }
            }
            else
            {
                throw new ArgumentException("La fecha de inicio debe ser anterior o igual a la fecha de fin, y la frecuencia debe ser mayor a cero.");
            }
        }

        //funcion que utiliza la funcion calcularddiasparalaproximaendulzada y muestra en pantalla la informacion 
        private void btnProximaEndulzada_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = fechaInicio.Value;
            DateTime fechaFinal = fechaFin.Value;
            DateTime fechaX = fechaActual.Value;
            int frecuenciaEndulzadas = (int)frecuencia.Value;

            try
            {
                int diasParaProximaEndulzada = CalcularDiasParaProximaEndulzada(fechaInicial, fechaFinal, fechaX, frecuenciaEndulzadas);
                lblproxEndul.Text = "Faltan: " + diasParaProximaEndulzada.ToString() + " Días para la próxima endulzada";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //condicionando textbox para que solo reciban datso numericos 
        private void txtCantJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un numero");
            }                 
        }

        //condicionando textbox para que solo reciban datso numericos 

        private void txtVendulzada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un numero valido");
            }
        }

        //condicionando textbox para que solo reciban datso numericos 

        private void txtVregalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un numero valido");
            }
        }
    }
}
