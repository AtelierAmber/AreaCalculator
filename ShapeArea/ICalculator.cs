using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
  internal interface ICalculator { }
  public abstract class Calculator<T> : ICalculator where T : IShapeDesignation
  {
    public abstract float CalculateArea(T designation);
  }
}
