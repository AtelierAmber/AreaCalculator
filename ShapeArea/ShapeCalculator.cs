using System.Security.Cryptography.X509Certificates;
using ShapeArea.Calculators;
using ShapeArea.Calculators.Designations;

namespace ShapeArea
{
  public static class ShapeCalculator
  {
    private static Dictionary<EShape, ICalculator> calculators = new();
    private static Dictionary<Type, EShape> calculatorShapes = new();

    private static bool setup = false;

    public static CalculatorParameters CalcParameters;
    public static void Setup(CalculatorParameters param)
    {
      if (setup)
      {
        return;
      }
      setup = true;
      CalcParameters = param;
      // Initialize Circle Calculator
      calculators.Add(EShape.CIRCLE, new CircleCalculator());
      calculatorShapes.Add(typeof(CircleDesignation), EShape.CIRCLE);
    }


    /// <summary>
    /// Calculates the area of passed in shapeDesignation. Will automatically select the correct
    /// calculator from the available calculators assuming the shapeDesignation has an associated calculator
    /// </summary>
    /// <typeparam name="S">Type of the shapeDesignation parameter</typeparam>
    /// <param name="shapeDesignation">A designation of the shape with included parameters. In the instance of
    /// a circle, it includes only its radius</param>
    /// <returns>Returns the area of the passed in shapeDesignation based on the initialized calculators</returns>
    /// <exception cref="NotSupportedException">Will throw this exception if the passed in 
    /// shapeDesignation does not have a suitable calculator</exception>
    public static float CalculateArea<S>(S shapeDesignation) where S : IShapeDesignation
    {
      Calculator<S>? calculator = (Calculator<S>?)calculators.GetValueOrDefault(calculatorShapes.GetValueOrDefault(typeof(S), EShape.INVALID), null);
      if (calculator == null)
      {
        throw new NotSupportedException("Shape designation of type " + typeof(S) + " is not supported currently!");
      }

      return calculator.CalculateArea(shapeDesignation);
    }

    internal static float RoundByParameters(float val)
    {
      // Used to scale the rounded value for rounding
      float scalar = MathF.Pow(10, CalcParameters.decimalPlaces);

      switch (CalcParameters.rounding)
      {
        case ERounding.TRUNCATE:
        case ERounding.DOWN:
          return ((int)(val * scalar)) / scalar; 
        case ERounding.UP:
          return MathF.Ceiling(((int)(val * scalar * 10.0f)) / 10.0f) / scalar;
        case ERounding.DEFAULT:
          return MathF.Round(((int)(val * scalar * 10.0f)) / 10.0f) / scalar;
        default:
          throw new NotImplementedException();
      }
    }
  }
}
