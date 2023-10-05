using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_Movil_JEVB
{
    
     public partial class MainPage : ContentPage
    {

        private string entrada = ""; // Para almacenar la entrada de usuario.
        private double resultado = 0.0; // Para almacenar el resultado de las operaciones.
        private string operacionActual = "";



        public MainPage()
        {
            InitializeComponent();



        }

        private void ActualizarDisplay()
        {
            ResultadoOperacion.Text = entrada;
        }

        private void Button_ClickedNumero(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            entrada += boton.Text; // Agregar el número al texto de entrada
            ActualizarDisplay();
        }

        private void Button_ClickedSuma(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!string.IsNullOrEmpty(entrada))
            {
                double numero = double.Parse(entrada);

                resultado += numero; // Suma

                entrada = ""; // Limpiar la entrada para la siguiente operación
                operacionActual = boton.Text; // Actualizar la operación actual
                ActualizarDisplay();
            }


        }

        private void Button_ClickedResta(object sender, EventArgs e)
        {


        }
        private void Button_ClickedDivicion(object sender, EventArgs e)
        {

        }
        private void Button_ClickedMultiplicar(object sender, EventArgs e)
        {

        }



        /*private void Button_ClickedOperacion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!string.IsNullOrEmpty(entrada))
            {
                double numero = double.Parse(entrada);

                switch (boton.Text)
                {
                    case "+":
                        resultado += numero;
                        break;
                    case "-":
                        resultado -= numero;
                        break;
                    case "*":
                        resultado *= numero;
                        break;
                    case "/":
                        if (numero != 0)
                            resultado /= numero;
                        else
                            ResultadoOperacion.Text = "Error: división por cero";
                        break;
                }

                entrada = ""; // Limpiar la entrada para la siguiente operación
                operacionActual = boton.Text; // Actualizar la operación actual
                ActualizarDisplay();
            }
        }*/



        private void Button_ClickedCero(object sender, EventArgs e)
        {


        }

        private void Button_ClickedAC(object sender, EventArgs e)
        {
            entrada = "";
            resultado = 0.0;
            ActualizarDisplay();

        }


        private void Button_ClickedBorrar(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entrada))
            {
                entrada = entrada.Substring(0, entrada.Length - 1);
                ActualizarDisplay();
            }

        }



        private void Button_ClickedIgual(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entrada))
            {
                double numero = double.Parse(entrada);

                switch (operacionActual)
                {
                    case "+":
                        resultado += numero;
                        break;
                    case "-":
                        resultado -= numero;
                        break;
                    case "*":
                        resultado *= numero;
                        break;
                    case "/":
                        if (numero != 0)
                            resultado /= numero;
                        else
                            ResultadoOperacion.Text = "Error: división por cero";
                        break;
                }

                entrada = resultado.ToString(); // Mostrar el resultado en la entrada
                operacionActual = ""; // Limpiar la operación actual
                ActualizarDisplay(); //
            }
        }




     }
}
