using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models
{
    public class Rectangulo : IFormaGeometrica
    {
        private decimal _base1 { get; set; }
        private decimal _alto { get; set; }

        public Rectangulo(decimal base1, decimal alto)
        {
            _base1 = base1;
            _alto = alto;
        }
        public decimal CalcularArea()
        {
            return _base1 * _alto;
        }

        public decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
