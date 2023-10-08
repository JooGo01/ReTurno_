using MaterialSkin.Animations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EjemploABM
{
    public class InfoMesCalendario
    {
        private int _mes;
        private int _anio;
        private DateTime[,] _dia;

        public InfoMesCalendario()
        {
            _mes = DateTime.Now.Month;
            _anio = DateTime.Now.Year;
            _dia = new DateTime[6, 7];
            establecerDia();
        }

        public InfoMesCalendario(int mes, int anio)
        {
            if (anio < 1 || anio > 9999)
            {
                throw new ArgumentOutOfRangeException("anio");
            }
            if (mes < 1 || mes > 12)
            {
                throw new ArgumentOutOfRangeException("mes");
            }
            _mes = mes;
            _anio = anio;
            _dia = new DateTime[6, 7];
            establecerDia();
        }

        private void establecerDia()
        {
            DateTime primerDia = new DateTime();
            int col = 0;
            int indexFila = 0;
            int indexCol = 0;
            int aggDia = 1;
            DateTime primerDiaGrilla = new DateTime();
            DateTime grillaFecha = new DateTime();
            DateTime grillaFechaNueva = new DateTime();

            primerDiaGrilla = new DateTime(_anio, _mes, 1);
            // col = int.Parse(primerDiaGrilla.DayOfWeek.ToString());
            col = (int)primerDiaGrilla.DayOfWeek;
            primerDia = primerDiaGrilla.AddDays(col * -1);

            grillaFechaNueva = primerDia;

            for (indexFila = 0; indexFila < 6; indexFila++)
            {
                for (indexCol = 0; indexCol < 7; indexCol++)
                {
                    grillaFecha = grillaFechaNueva;
                    _dia[indexFila, indexCol] = grillaFecha;
                    grillaFechaNueva = grillaFechaNueva.AddDays(aggDia);
                }
            }
        }

        public void irMes(int anio, int mes)
        {
            if (anio < 1 || anio > 9999)
            {
                throw new ArgumentOutOfRangeException("anio");
            }
            if (mes < 1 || mes > 12)
            {
                throw new ArgumentOutOfRangeException("mes");
            }

            _anio = anio;
            _mes = mes;
            establecerDia();
        }

        public int diaDeMes(int fila, int col)
        {
            if (fila < 0 && fila > 5)
            {
                throw new ArgumentOutOfRangeException("fila");
            }

            if (col < 0 && col > 6)
            {
                throw new ArgumentOutOfRangeException("col");
            }

            return _dia[fila, col].Day;
        }

        public bool esMesActivo(int fila, int col)
        {
            bool activo = false;
            if (fila < 0 && fila > 5)
            {
                throw new ArgumentOutOfRangeException("fila");
            }

            if (col < 0 && col > 6)
            {
                throw new ArgumentOutOfRangeException("col");
            }

            if (_dia[fila, col].Month == _mes)
            {
                activo = true;
            }
            else
            {
                activo = false;
            }

            return activo;
        }

        public bool esHoy(int fila, int col)
        {
            bool hoy = false;
            if (fila < 0 && fila > 5)
            {
                throw new ArgumentOutOfRangeException("fila");
            }

            if (col < 0 && col > 6)
            {
                throw new ArgumentOutOfRangeException("col");
            }

            if (_dia[fila, col].Date == DateTime.Now.Date)
            {
                hoy = true;
            }
            else
            {
                hoy = false;
            }

            return hoy;
        }

        public int fncFila(DateTime dt)
        {
            int indexCol = 0;
            int indexFila = 0;

            for (indexFila = 0; indexFila < 6; indexFila++)
            {
                for (indexCol = 0; indexCol < 7; indexCol++)
                {
                    if (_dia[indexFila, indexCol].Date == dt)
                    {
                        return indexFila;
                    }
                }
            }

            return -1;
        }

        public int fncColumna(DateTime dt)
        {
            int indexCol = 0;
            int indexFila = 0;

            for (indexFila = 0; indexFila < 6; indexFila++)
            {
                for (indexCol = 0; indexCol < 7; indexCol++)
                {
                    if (_dia[indexFila, indexCol].Date == dt)
                    {
                        return indexCol;
                    }
                }
            }

            return -1;
        }

        public bool fechaExistente(DateTime dt)
        {
            bool existe = false;
            if (fncFila(dt) > -1)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
        }

        public int getMes()
        {
            return _mes;
        }

        public void setMes(int mes) {
            _mes = mes;
        }

        public int getAnio() {
            return _anio;
        }

        public void setAnio(int anio) { 
            _anio = anio;
        }

    }
}
