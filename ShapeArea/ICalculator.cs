using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
  internal interface ICalculator<T> where T : IShapeDesignation
  {
    public float CalculateArea(T designation) { throw new NotImplementedException(); }
  }
}
