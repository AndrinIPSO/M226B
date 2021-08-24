using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    interface IDraw
    {
        string Color { get; set; }
        void Draw();
    }
}
