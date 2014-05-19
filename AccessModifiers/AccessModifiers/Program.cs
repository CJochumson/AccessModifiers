using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccModLib;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.indexPublic = 0;
            //shape.indexProtected = 0;
            //shape.indexInternal = 0;
            //shape.indexProtectedInternal = 0;
            Shape rect = new Rect();
            rect.indexPublic = 0;
            //rect.indexProtected = 0;
            //rect.indexInternal = 0;
            //rect.indexProtectedInternal = 0;
        }

        private class Rect : Shape
        {
            public Rect()
            {
                this.indexPublic = 0;
                this.indexProtected = 0;
                //this.indexInternal = 0;
                this.indexProtectedInternal = 0;
            }
        }

    }
}
