using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Boligrafo
{
    class boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if(tinta >= -100 && tinta <= cantidadTintaMaxima)
            {
                short auxTinta = GetTinta();
                auxTinta += tinta;
                if (auxTinta <= cantidadTintaMaxima && auxTinta >= -100)
                {
                    this.tinta = auxTinta;
                }
                else
                {
                    Console.WriteLine("Error: La tinta supera los limites.");
                }
            }
        }
        public void Recargar()
        {
            short auxTinta = cantidadTintaMaxima;
            auxTinta -= GetTinta();
            SetTinta(auxTinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool pintadoMaestro;
            SetTinta(gasto);
            dibujo = "";
            if(this.tinta > 0)
            {
                pintadoMaestro = true;
            }
            else
            {
                pintadoMaestro = false;
            }

            return pintadoMaestro;
        }

    }
}
