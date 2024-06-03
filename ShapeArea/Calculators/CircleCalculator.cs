using System;
using System.Collections.Generic;
using System.Text;
using ShapeArea.Calculators.Designations;

namespace ShapeArea.Calculators
{
  public class CircleCalculator : Calculator<CircleDesignation>
  {
    public CircleCalculator() { }

    /// <summary>
    /// Calculates the area of the circle described by the param designation. Uses rounding
    /// rules specified in <see cref="ShapeCalculator.calcParameters"/>.
    /// </summary>
    /// <param name="designation">A circle described by its radius</param>
    /// <returns>The area (PI * radius squared) rounded based on rounding rules in <see cref="ShapeCalculator.calcParameters"/></returns>
    public override float CalculateArea(CircleDesignation designation)
    {
      CalculatorParameters parameters = ShapeCalculator.CalcParameters;

      float areaUnrounded = designation.radius * designation.radius * parameters.PI;
      float areaRounded = ShapeCalculator.RoundByParameters(areaUnrounded);

      return areaRounded;
    }
  }
}
