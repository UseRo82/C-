using System;
using System.Collections.Generic;
using System.Text;

namespace Interfasce
{
    internal class AvisoTrafico : IAvisos
    {
        public AvisoTrafico()
        {
            remitente = "DGT.";
            mensaje = "Sanción cometida.";
            fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
