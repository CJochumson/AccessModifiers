using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiersLib;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.PublicField = 0;
            //shape.ProtectedField = 0;
            //shape.InternalField = 0;
            //shape.ProtectedInternalField = 0;
            //shape.PrivateField = 0;
            //shape.Field = 0;

            Shape rect = new Rect();
            //rect.PublicField = 0;
            //rect.ProtectedField = 0;
            //rect.InternalField = 0;
            //rect.ProtectedInternalField = 0;
            //rect.PrivateField = 0;
            //rect.Field = 0;

            Abstract.Test();
            Virtual.Test();
            Console.ReadLine();
        }

        class Rect : Shape
        {
            public Rect()
            {
                PublicField = 0;
                ProtectedField = 0;
                //InternalField = 0;
                ProtectedInternalField = 0;
                //PrivateField = 0;
                //Field = 0;
            }
        }
    }
}
