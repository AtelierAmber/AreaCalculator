using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
  public struct CalculatorParameters
  {
    public float PI; // Can be used to specify a decimal limit for PI.
    public int decimalPlaces; // Used to determine where rounding occurs
    public ERounding rounding; // Used to determine rounding behavior
  }
}
