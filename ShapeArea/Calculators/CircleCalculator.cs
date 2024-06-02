using System;
using System.Collections.Generic;
using System.Text;
using ShapeArea.Calculators.Designations;

namespace ShapeArea.Calculators
{
  public class CircleCalculator : Calculator<CircleDesignation>
  {
    public CircleCalculator() { }

    public override float CalculateArea(CircleDesignation designation)
    {
      CalculatorParameters parameters = ShapeCalculator.calcParameters;

      float areaUnrounded = designation.radius * designation.radius * parameters.PI;
      float areaRounded = ShapeCalculator.RoundByParameters(areaUnrounded);

      return areaRounded;
    }
  }
}
