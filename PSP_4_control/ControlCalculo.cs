using PSP_4_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_4_control
{
    public static class ControlCalculo
    {
        public static void ReglaSimpson()
        {
            Iterador i = Aplicacion.getInstancia().ColeccionDato.Iterador();
            Dato d;

            while(i.tieneSiguiente())
            {
                d = i.Siguiente();

                String Respuesta = "";
                Double Segmentos = 10;
                Double W = d.x2 / Segmentos;
                Double RaizPi = Math.Sqrt(Math.PI);
                Double t1 = CalcularGama((d.dof + 1)/2);
                Double t2 = CalcularGama(d.dof / 2);
                Double Constante = Math.Pow(d.dof * Math.PI,0.5);

                double[] VectorCalculos = new double[10];
                Double CalculoTotal = 0;

                for (int x = 0; x <= 10; x++)
                {
                    /// 0. i
                    VectorCalculos[0] = x;
                    /// 1. Xi
                    VectorCalculos[1] = x * W;
                    /// 2. 1 + (Xi^2/Dof)
                    VectorCalculos[2] = 1 + (Math.Pow(VectorCalculos[1], 2) / d.dof);
                    /// 3. 1 + (Xi^2/Dof)
                    VectorCalculos[3] = Math.Pow(VectorCalculos[2], t1);
                    /// 4. T((dof+1)/2) / (((dof*PI)^1/2) * T(dof/2)))
                    VectorCalculos[4] = t1 / (Constante * t2);
                    /// 5. -(dof+1)/2
                    VectorCalculos[5] = -((d.dof + 1) / 2);
                    /// 6. -(dof+1)/2
                    VectorCalculos[6] = (1 + (Math.Pow(VectorCalculos[1], 2) / d.dof));
                    /// 7. T((dof+1)/2) / (((dof*PI)^1/2)  T(dof/2)))  (1 + (Xi^2/Dof))^-(dof+1)/2
                    VectorCalculos[7] = VectorCalculos[4] * Math.Pow(VectorCalculos[6], VectorCalculos[5]);
                    /// 8. Multiplicador
                    switch (x)
                    {
                        case 0:
                        case 10:
                            VectorCalculos[8] = 1;
                            break;
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 9:
                            VectorCalculos[8] = 4;
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                            VectorCalculos[8] = 2;
                            break;
                    }

                    /// 9. Terms
                    VectorCalculos[9] = (W / 3) * VectorCalculos[8] * VectorCalculos[7];

                    CalculoTotal += VectorCalculos[9];
                }

                Respuesta = String.Format("x1 = {0} - x2 = {1} - dof = {2} - p = {3}", d.x1, d.x2, d.dof, Math.Round(CalculoTotal, 5));

                Console.WriteLine(Respuesta);
            }
        }


        private static Double CalcularGama(Double Numero)
        {
            int i = 0;
            string s = Numero.ToString();
            double respuesta = 1;

            if (int.TryParse(s, out i))
            {
                for (int a = ((int)Numero - 1); a > 1; a--)
                {
                    respuesta = respuesta * a;
                    Numero--;
                }
            }
            else
            {
                for (double a = ((double)Numero - 1); a > 0; a--)
                {
                    if (a <= 0.5)
                        respuesta = respuesta * 0.5 * Math.Sqrt(Math.PI);
                    else
                        respuesta = respuesta * a;

                    Numero--;
                }
            }

            return respuesta;
        }
    }
}