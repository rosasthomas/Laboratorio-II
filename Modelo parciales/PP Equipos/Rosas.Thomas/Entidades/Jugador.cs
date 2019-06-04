using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

       public float Altura { get { return this.altura; } }

       public float Peso { get { return this.peso; } }

       public Posicion Posicion { get { return this.posicion; } }

       public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " - Altura: " + this.Altura + " - Peso: " + this.Peso + " - Posicion: " + this.Posicion;  
        }

        public override bool ValidarAptitud()
        {
            bool flag = false;

            if (this.Edad <= 40 && this.ValidarEstadoFisico())
            {
                flag = true;
            }

            return flag;
        }

        public bool ValidarEstadoFisico()
        {
            bool flag = false;
            float IMC;            IMC = this.Peso / (float)Math.Pow(this.Altura, 2);
            if (IMC >= 18.5 && IMC <= 25)
            {
                flag = true;
            }

            return flag;
        }

    }
}
