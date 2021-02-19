using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models
{
    /// <summary>
    /// Implementacion del trapecio
    /// </summary>
    public class Trapecio : IFormaGeometrica
    {
        private decimal _base1 { get; set; }
        private decimal _base2 { get; set; }
        private decimal _alto { get; set; }

        public Trapecio(decimal base1, decimal base2, decimal alto)
        {
            _base1 = base1;
            _base2 = base2;
            _alto = alto;
        }
        public decimal CalcularArea()
        {
            return (_base1 + _base2) * _alto / 2;
        }

        public decimal CalcularPerimetro()
        {
            //aca hay tongo
            return (_base1 + _base2) * _alto / 2;
        }
    }
}
