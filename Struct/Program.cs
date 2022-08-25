﻿using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);

            empleado1.cambiaSalario(empleado1, 100);

            Console.WriteLine(empleado1);
        }
    }
    public struct Empleado
    {
        public double salarioBase, comision;

        //Constructor.
        public Empleado( int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return String.Format("Salario y comisión del empleado ({0}, {1})", this.salarioBase, this.comision);
        }
        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
