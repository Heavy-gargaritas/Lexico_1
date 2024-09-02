using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexico_1
{
    public class Token
    {
        public enum Tipos
        {
            Identificador, Numero, Caracter, FinSentencia,
            inicioBloque, FinBloque, OperadorTernario,
            OperadorTermino
        }
        private String contenido;
        private Tipos clasificacion;

        public Token()
        {
            contenido = "";
            clasificacion = Tipos.Identificador;
        }

        public void setContenido(String contenido)
        {
            this.contenido = contenido;
        }

        public void setClasificacion(Tipos clasificacion)
        {
            this.clasificacion = clasificacion;
        }

        public String getContenido()
        {
            return this.contenido;
        }

        public Tipos getClasificacion()
        {
            return this.clasificacion;
        }
    }
}