using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{

  /// <summary>
  /// Used only to define a calculator. Holds no functionality and is only used internally
  /// </summary>
  internal interface ICalculator { }


  /// <summary>
  /// Calculator class. Can be added onto in the future with additional functions
  /// Currently only includes the Calculate area function.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public abstract class Calculator<T> : ICalculator where T : IShapeDesignation
  {
    /// <summary>
    /// Calculates the area of the shape with designation, <typeparamref name="T"/> this calculator is associated with
    /// </summary>
    /// <param name="designation">The shape designation with associated information needed for calculations</param>
    /// <returns>The area of the shape with designation, <typeparamref name="T"/></returns>
    public abstract float CalculateArea(T designation);
  }
}
