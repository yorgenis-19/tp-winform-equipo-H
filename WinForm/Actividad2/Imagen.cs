using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    public class Imagen
    {
        public  string url { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return url;
        }
    }
}
