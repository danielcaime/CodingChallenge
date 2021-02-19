/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Models;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// clase para manipular formas geometricas
    /// </summary>
    public class FormaGeometrica
    {
        /// <summary>
        /// imprime un reporte de las formas geometricas
        /// </summary>
        /// <param name="formas"></param>
        /// <returns></returns>
        public static string Imprimir(List<IFormaGeometrica> formas)
        {
            var sb = new StringBuilder();
            if (!formas.Any())
            {
                sb.Append(Labels.Empty_List);
            }
            else
            {
                sb.Append(Labels.Shapes_report);

                var totalcount = 0m;
                var totalareas = 0m;
                var totalperimetros = 0m;

                var lists = formas.GroupBy(f => f.GetType());

                foreach (var item in lists)
                {
                    var name = item.Key.Name;
                    var count = item.Count();
                    totalcount += count;
                    var areas = item.Sum(f => f.CalcularArea());
                    totalareas += areas;
                    var perimetros = item.Sum(f => f.CalcularPerimetro());
                    totalperimetros += perimetros;
                    sb.Append(ObtenerLinea(count, areas, perimetros, name));
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(totalcount + " " + Labels.shapes + " ");
                sb.Append(Labels.Perimeter + " " + (totalperimetros).ToString("#.##") + " ");
                sb.Append("Area " + (totalareas).ToString("#.##"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// genera una linea para el reporte
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="area"></param>
        /// <param name="perimetro"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string name)
        {
            ResourceManager resource = new ResourceManager(typeof(Labels));

            if (cantidad > 0)
            {
                return $"{cantidad} {resource.GetString(name)} | {Labels.Area} {area:#.##} | {Labels.Perimeter} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

    }
}
