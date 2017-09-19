using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillers
{
    interface IShape
    {
        string Name { get; set; }
        void GetInfo();
        double Area();

    }
}
