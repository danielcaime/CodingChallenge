using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interfaces
{
    /// <summary>
    /// interface de formas geometricas
    /// </summary>
    public interface IFormaGeometrica
    {
        /// <summary>
        /// Calcula el area
        /// </summary>
        /// <returns></returns>
        decimal CalcularArea();

        /// <summary>
        /// Calcula el perimetro
        /// </summary>
        /// <returns></returns>
        decimal CalcularPerimetro();
    }
}
