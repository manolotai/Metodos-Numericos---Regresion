using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBackPack;
using Jace;

namespace Regresion {
    public static class RegresionExtend {
        public static MatrizMath Regresion(List<JaceFunciones.Point> puntos, int grado)
        {
            var solucion = new double[grado + 1];
            var coeficientes = new double[grado + 1, grado + 1];

            for (int i = 0; i < solucion.Length; i++) {
                solucion[i] = puntos.Sum(
                    p => ((Func<double,double,double>)
                    new CalculationEngine().FxN(String.Format("x^{0}*y", i), "x", "y"))(p.X, p.Y));
            }
            for (int y = 0; y < coeficientes.GetLength(0); y++) {
                for (int x = 0, i = y; x < coeficientes.GetLength(1); x++, i++) {
                    coeficientes[x, y] = puntos.Sum(
                    p => ((Func<double, double>)
                    new CalculationEngine().FxN(String.Format("x^{0}", i), "x"))(p.X));
                }
            }

            return CMatrizCalc.GaussJordan(new MatrizMath(coeficientes, solucion)).Matriz;
        }
    }
}
