using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Entidades.SP
{
    public class Manejadora <T>
    {
        public void Manejador(object sender)
        {
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PrecioExcedido.txt", true);

            try
            {
                writer.WriteLine("Fecha: " + DateTime.Now);
                writer.WriteLine("Precio total del cajon: " + ((Cajon<T>)sender).PrecioTotal);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
