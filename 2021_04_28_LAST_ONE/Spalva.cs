using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_28_LAST_ONE
{
    public class Spalva
    {
        public Spalva()
        {
            R = G = B = 255;
        }
        public Spalva(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public void SetColors(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public byte GetGreyscale()
        {
            return (byte)((R + G + B) / 3);
        }
    }
    public class Kamuolys
    {

    }
}