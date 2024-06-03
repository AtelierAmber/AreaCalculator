using System;
using System.Collections.Generic;
using System.Text;
using ShapeArea.Calculators.Designations;

namespace ShapeArea.Calculators
{
  public class SphereCalculator : Calculator<SphereDesignation>
  {
    public SphereCalculator() { }

    /// <summary>
    /// Calculates the area of the sphere described by the param designation. Uses rounding
    /// rules specified in <see cref="ShapeCalculator.calcParameters"/>.
    /// </summary>
    /// <param name="designation">A sphere described by its radius</param>
    /// <returns>The area (PI * radius squared) rounded based on rounding rules in <see cref="ShapeCalculator.calcParameters"/></returns>
    public override float CalculateArea(SphereDesignation designation)
    {
      CalculatorParameters parameters = ShapeCalculator.CalcParameters;

      float areaUnrounded = 4.0f * designation.radius * designation.radius * parameters.PI;
      float areaRounded = ShapeCalculator.RoundByParameters(areaUnrounded);

      return areaRounded;
    }
  }
}
