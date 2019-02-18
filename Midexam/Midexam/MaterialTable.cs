using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam
{
    public class Element
    {
        public Shapetype.Material MaterialType { get; set; }
        public string Name { get; set; }
        public double Density { get; set; }

        public Element(Shapetype.Material mtype,string name,double density)
        {
            MaterialType = mtype;
            Name = name;
            Density = density;
        }
    }

    public static class MaterialTable
    {
        public static Element[] element = { new Element(Shapetype.Material.AL,"鋁",2.7),
                                            new Element(Shapetype.Material.FE,"鐵",7.87),
                                            new Element(Shapetype.Material.PB,"鉛",11.3)};

        public static Shapetype.Material MarerialType(string name)
        {
            foreach(var e in element)
            {
                if (e.Name == name)
                    return e.MaterialType;
            }
            return Shapetype.Material.UNKNOWN;
        }

        public static double Density(string name)
        {
            foreach(var e in element)
            {
                if (e.Name == name)
                    return e.Density;
            }
            return 0;
        }

        public static double Density(Shapetype.Material mtype)
        {
            foreach (var e in element)
            {
                if (e.MaterialType == mtype)
                    return e.Density;
            }
            return 0;
        }
    }
}
