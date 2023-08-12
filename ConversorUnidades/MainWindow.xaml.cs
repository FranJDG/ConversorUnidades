using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConversorUnidades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valorEntrada;
        double resultado;
        string unidadEntrada;
        string unidadSalida;        

        public MainWindow()
        {
            InitializeComponent();            
        }
        
        private void SelectorEntrada(object sender, RoutedEventArgs e)
        {
            var boton = (Button)sender;
            unidadEntrada = Convert.ToString(boton.Content);
            UnidadEntrada.Text = unidadEntrada;
        }

        private void Convertir(object sender, RoutedEventArgs e)
        {
            var boton = (Button)sender;
            unidadSalida = Convert.ToString(boton.Content);
            UnidadSalida.Text = unidadSalida;

            string entrada = Entrada.Text;
            if (entrada.Contains("."))
            {
                entrada = entrada.Replace(".", ",");
            }

            Regex regex = new Regex(@"^-?\d+(?:,\d+)?$");

            if (!regex.IsMatch(entrada))
            {
                MessageBox.Show("Introduce un valor de entrada válido", "Advertencia");
            }
            else
            {
                valorEntrada = Convert.ToDouble(entrada);

                if (unidadEntrada != "")
                {
                    //Temperatura----------------------------------------------------------------------
                    //Celsius
                    if (unidadEntrada == "Celsius" && unidadSalida == "Celsius")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Celsius" && unidadSalida == "Fahrenheit")
                    {
                        resultado = (valorEntrada * 9 / 5) + 32;
                    }
                    else if (unidadEntrada == "Celsius" && unidadSalida == "Kelvin")
                    {
                        resultado = valorEntrada + 273.15;
                    }
                    //Fahrenheit
                    else if (unidadEntrada == "Fahrenheit" && unidadSalida == "Fahrenheit")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Fahrenheit" && unidadSalida == "Celsius")
                    {
                        resultado = (valorEntrada - 32) * 5 / 9;
                    }
                    else if (unidadEntrada == "Fahrenheit" && unidadSalida == "Kelvin")
                    {
                        resultado = (valorEntrada - 32) * 5 / 9 + 273.15;
                    }
                    //Kelvin
                    else if (unidadEntrada == "Kelvin" && unidadSalida == "Kelvin")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Kelvin" && unidadSalida == "Celsius")
                    {
                        resultado = valorEntrada - 273.15;
                    }
                    else if (unidadEntrada == "Kelvin" && unidadSalida == "Fahrenheit")
                    {
                        resultado = (valorEntrada - 273.15) * 9 / 5 + 32;
                    }

                    //Longitud---------------------------------------------------------------
                    //Metros
                    else if (unidadEntrada == "Metros" && unidadSalida == "Metros")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Metros" && unidadSalida == "Pulgadas")
                    {
                        resultado = valorEntrada * 39.37;
                    }
                    else if (unidadEntrada == "Metros" && unidadSalida == "Pies")
                    {
                        resultado = valorEntrada * 3.281;
                    }
                    //Pulgadas
                    else if (unidadEntrada == "Pulgadas" && unidadSalida == "Pulgadas")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Pulgadas" && unidadSalida == "Metros")
                    {
                        resultado = valorEntrada / 39.37;
                    }
                    else if (unidadEntrada == "Pulgadas" && unidadSalida == "Pies")
                    {
                        resultado = valorEntrada / 12;
                    }
                    //Pies
                    else if (unidadEntrada == "Pies" && unidadSalida == "Pies")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Pies" && unidadSalida == "Metros")
                    {
                        resultado = valorEntrada / 3.281;
                    }
                    else if (unidadEntrada == "Pies" && unidadSalida == "Pulgadas")
                    {
                        resultado = valorEntrada * 12;
                    }
                    //Peso------------------------------------------------------------------------
                    //Kilogramos
                    else if (unidadEntrada == "Kilogramos" && unidadSalida == "Kilogramos")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Kilogramos" && unidadSalida == "Libras")
                    {
                        resultado = valorEntrada * 2.205;
                    }
                    else if (unidadEntrada == "Kilogramos" && unidadSalida == "Onzas")
                    {
                        resultado = valorEntrada * 35.274;
                    }
                    //Libras
                    else if (unidadEntrada == "Libras" && unidadSalida == "Libras")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Libras" && unidadSalida == "Kilogramos")
                    {
                        resultado = valorEntrada / 2.205;
                    }
                    else if (unidadEntrada == "Libras" && unidadSalida == "Onzas")
                    {
                        resultado = valorEntrada * 16;
                    }
                    //Onzas
                    else if (unidadEntrada == "Onzas" && unidadSalida == "Onzas")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Onzas" && unidadSalida == "Kilogramos")
                    {
                        resultado = valorEntrada / 35.274;
                    }
                    else if (unidadEntrada == "Onzas" && unidadSalida == "Libras")
                    {
                        resultado = valorEntrada / 16;
                    }

                    //Tiempo----------------------------------------------------------------------
                    //Segundos
                    else if (unidadEntrada == "Segundos" && unidadSalida == "Segundos")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Segundos" && unidadSalida == "Minutos")
                    {
                        resultado = valorEntrada / 60;
                    }
                    else if (unidadEntrada == "Segundos" && unidadSalida == "Horas")
                    {
                        resultado = valorEntrada / 3600;
                    }
                    //Minutos
                    else if (unidadEntrada == "Minutos" && unidadSalida == "Minutos")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Minutos" && unidadSalida == "Segundos")
                    {
                        resultado = valorEntrada * 60;
                    }
                    else if (unidadEntrada == "Minutos" && unidadSalida == "Horas")
                    {
                        resultado = valorEntrada / 60;
                    }
                    //Horas
                    else if (unidadEntrada == "Horas" && unidadSalida == "Horas")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Horas" && unidadSalida == "Segundos")
                    {
                        resultado = valorEntrada * 3600;
                    }
                    else if (unidadEntrada == "Horas" && unidadSalida == "Minutos")
                    {
                        resultado = valorEntrada * 60;
                    }

                    //Velocidad--------------------------------------------------------------------
                    //Km/h
                    else if (unidadEntrada == "Km/h" && unidadSalida == "Km/h")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "Km/h" && unidadSalida == "mph")
                    {
                        resultado = valorEntrada / 1.609;
                    }
                    else if (unidadEntrada == "Km/h" && unidadSalida == "m/s")
                    {
                        resultado = valorEntrada / 3.6;
                    }
                    //mph
                    else if (unidadEntrada == "mph" && unidadSalida == "mph")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "mph" && unidadSalida == "Km/h")
                    {
                        resultado = valorEntrada * 1.609;
                    }
                    else if (unidadEntrada == "mph" && unidadSalida == "m/s")
                    {
                        resultado = valorEntrada / 2.237;
                    }
                    //m/s
                    else if (unidadEntrada == "m/s" && unidadSalida == "m/s")
                    {
                        resultado = valorEntrada;
                    }
                    else if (unidadEntrada == "m/s" && unidadSalida == "Km/h")
                    {
                        resultado = valorEntrada * 3.6;
                    }
                    else if (unidadEntrada == "m/s" && unidadSalida == "mph")
                    {
                        resultado = valorEntrada * 2.237;
                    }

                    //Errores por unidades de conversion incorrecta--------------------------------
                    else if ((unidadEntrada == "Celsius" || unidadEntrada == "Fahrenheit" || unidadEntrada == "Kelvin") && (unidadSalida != "Celsius" || unidadSalida != "Fahrenheit" || unidadSalida != "Kelvin"))
                    {
                        resultado = 0;
                        MessageBox.Show($"Unidades de conversión incorrecta.\nNo es posible convertir de {unidadEntrada} a {unidadSalida}", "Advertencia");
                    }
                    else if ((unidadEntrada == "Metros" || unidadEntrada == "Pulgadas" || unidadEntrada == "Pies") && (unidadSalida != "Metros" || unidadSalida != "Pulgadas" || unidadSalida != "Pies"))
                    {
                        resultado = 0;
                        MessageBox.Show($"Unidades de conversión incorrecta.\nNo es posible convertir de {unidadEntrada} a {unidadSalida}", "Advertencia");
                    }
                    else if ((unidadEntrada == "Kilogramos" || unidadEntrada == "Libras" || unidadEntrada == "Onzas") && (unidadSalida != "Kilogramos" || unidadSalida != "Libras" || unidadSalida != "Onzas"))
                    {
                        resultado = 0;
                        MessageBox.Show($"Unidades de conversión incorrecta.\nNo es posible convertir de {unidadEntrada} a {unidadSalida}", "Advertencia");
                    }
                    else if ((unidadEntrada == "Segundos" || unidadEntrada == "Minutos" || unidadEntrada == "Horas") && (unidadSalida != "Segundos" || unidadSalida != "Minutos" || unidadSalida != "Horas"))
                    {
                        resultado = 0;
                        MessageBox.Show($"Unidades de conversión incorrecta.\nNo es posible convertir de {unidadEntrada} a {unidadSalida}", "Advertencia");
                    }
                    else if ((unidadEntrada == "Km/h" || unidadEntrada == "mph" || unidadEntrada == "m/s") && (unidadSalida != "Km/h" || unidadSalida != "mph" || unidadSalida != "m/s"))
                    {
                        resultado = 0;
                        MessageBox.Show($"Unidades de conversión incorrecta.\nNo es posible convertir de {unidadEntrada} a {unidadSalida}", "Advertencia");
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una unidad de entrada (botones con bordes verdes)", "Advertencia");
                }
            }  

            Salida.Text = Convert.ToString(resultado);             
        }

        private void AcercaDeClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Conversor de unidades\n\nCreado con WPF en Visual Studio\n\nv1.0 16/07/2023\nFran Díaz", "Acerca de");
        }
       
        
    }
}
