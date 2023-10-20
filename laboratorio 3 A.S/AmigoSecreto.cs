using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3_A.S
{
    internal class AmigoSecreto
    {
        String cantJugadores;
        String fechaInicio;
        String descubrimiento;
        String numEndulzadas;
        String frecuenciaEndulzadas;
        String valorEndulzada;
        String valorRegalo;


        public AmigoSecreto(String fechaInicio, String descubrimiento, String numEndulzadas,
            String frecuenciaEndulzadas, String valorEndulzada, String valorRegalo)
        {
            this.fechaInicio = fechaInicio;
            this.descubrimiento = descubrimiento;
            this.numEndulzadas = numEndulzadas;
            this.frecuenciaEndulzadas = frecuenciaEndulzadas;
            this.valorEndulzada = valorEndulzada;
            this.valorRegalo = valorRegalo;
        }
        public String getCantJugadores()
        {
            return cantJugadores;
        }
        public String getFechaInicio()
        {
            return fechaInicio;
        }
        public String getNumEndulzadas()
        {
            return numEndulzadas;
        }
        public String getFrecuenciaEndulzadas()
        {
            return frecuenciaEndulzadas;
        }
        public String getValorEndulzadas()
        {
            return valorEndulzada;
        }
        public String getValorRegalo()
        {
            return valorRegalo;
        }
        public void setCantJugadores(String cantJugadores)
        {
            this.cantJugadores = cantJugadores;
        }
        public void setFechaInicio(String fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }
        public void setNumEndulzadas(String numEndulzadas)
        {
            this.numEndulzadas = numEndulzadas;
        }
        public void setFrecuenciaEndulzadas(String frecuenciaEndulzadas)
        {
            this.frecuenciaEndulzadas = frecuenciaEndulzadas;
        }
        public void setValorEndulzadas(String valorEndulzada)
        {
            this.valorEndulzada = valorEndulzada;
        }
        public void setValorRegalo(String valorRegalo)
        {
            this.valorRegalo = valorRegalo;
        }
    }
}
