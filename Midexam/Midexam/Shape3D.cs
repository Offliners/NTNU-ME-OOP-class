using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam
{
    public class Shapetype
    {
        public enum Geometry
        {
            UNKNOWN = -1, BALL = 0,CUBE = 1,CYLINDER = 2,PYRAMID = 3
        };

        public enum Material
        {
            UNKNOWN = -1, AL = 0,FE = 1,PB = 2
        };
    }

    abstract class Shape3D
    {
        public static int _amount;
        public Shapetype.Geometry _shape;
        public Shapetype.Material _material;

        public Shape3D()
        {
            _material = Shapetype.Material.UNKNOWN;
            _amount++;
        }

        public Shape3D(Shapetype.Material mtype)
        {
            _material = mtype;
            _amount++;
        }

        public static int Amount
        {
            get { return _amount; }
        }

        public Shapetype.Material MaterialType
        {
            get { return _material; }
        }

        public Shapetype.Geometry ShapeType
        {
            get { return _shape; }
        }

        public double Weight()
        {
            return Volumn() * Density();
        }

        public double Density()
        {
            return MaterialTable.Density(_material);
        }

        public abstract double Volumn();

        public abstract string ShapeProperty();

        public string Property()
        {
            string str = "";
            str += string.Format("{0,8:F2}", Density());
            str += "\t";
            str += string.Format("{0,8:F2}", Volumn());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
}
