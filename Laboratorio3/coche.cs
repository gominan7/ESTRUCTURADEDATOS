using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    internal class coche
    {
        private int numero_Ruedas;
        private int numero_Puertas;
        private string color;
        private double velocidad;
        private bool encendido;

        public coche(int numero_Ruedas, int numero_Puertas, string color, double velocidad)
        {
            this.numero_Ruedas = numero_Ruedas;
            this.numero_Puertas = numero_Puertas;
            this.color = color;
            this.velocidad = velocidad;
        }

        public int Numero_Ruedas { get => numero_Ruedas; set => numero_Ruedas = value; }
        public int Numero_Puertas { get => numero_Puertas; set => numero_Puertas = value; }
        public string Color { get => color; set => color = value; }
        public double Velocidad { get => velocidad; set => velocidad = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        public string Encender()
        {
            Encendido = true;
            return "El vehiculo esta encendido" + this.Encendido;
        }
    }
}
