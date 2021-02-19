using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models
{
    public class Circulo : IFormaGeometrica
    {
        private decimal _lado { get; set; }

        public Circulo(decimal lado)
        {
            _lado = lado;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
