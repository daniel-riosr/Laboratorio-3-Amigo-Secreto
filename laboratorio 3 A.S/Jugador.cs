using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3_A.S
{
    internal class Jugador
    {
        String nombres;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        public Jugador(String nombres, String correo, String endulzadaIdeal, String regaloIdeal)
        {
            this.nombres = nombres;
            this.correo = correo;
            this.endulzadaIdeal = endulzadaIdeal;
            this.regaloIdeal = regaloIdeal;

        }
        public String getNombre()
        {
            return nombres;
        }
        public String getCorreo()
        {
            return correo;
        }
        public String getEndulzadaIdeal()
        {
            return endulzadaIdeal;
        }
        public String getRegaloIdeal()
        {
            return regaloIdeal;
        }
        public String getAmigoSecreto()
        {
            return amigoSecreto;
        }
        public void setNombre(String nombre)
        {
            this.nombres = nombre;
        }
        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
        public void setEndulzadaIdeal(String endulzadaIdeal)
        {
            this.endulzadaIdeal = endulzadaIdeal;
        }
        public void setRegaloIdeal(String regaloIdeal)
        {
            this.regaloIdeal = regaloIdeal;
        }
        public void setAmigoSecreto(String amigoSecreto)
        {
            this.amigoSecreto = amigoSecreto;
        }
    }
}
