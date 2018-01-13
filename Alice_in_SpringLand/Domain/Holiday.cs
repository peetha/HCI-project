using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavara.Domain
{
    class Holiday
    {
        public string name { get; set; }
        public Bitmap img { get; set; }

        public Holiday(string name, Bitmap img)
        {
            this.name = name;
            this.img = img;
        }
    }
}
