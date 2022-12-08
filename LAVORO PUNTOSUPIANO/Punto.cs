using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAVORO_PUNTOSUPIANO
{
    public class Punto
    {

        //ATTRIBUTI 

        private double _x;
        private double _y;

        //PROPERTIES
        public Punto(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Punto() : this(0,0)
        {
        }
        public double X
        {
            get
            {
                return _x;
            }
            private set
            {            
                    _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            private set
            {
                _y = value;
            }
        }
        //METODI
        public double Distanza2Punti(double x1, double y1, double x2, double y2)
        {
            double distanza = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            return distanza;
        }




    }
}
