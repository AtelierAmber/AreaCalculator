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
      throw new NotImplementedException();
    }
  }
}
