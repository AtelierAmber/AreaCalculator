using System.Security.Cryptography.X509Certificates;
using ShapeArea.Calculators;
using ShapeArea.Calculators.Designations;

namespace ShapeArea
{
  public static class ShapeCalculator
  {
    private static Dictionary<EShape, ICalculator> calculators = new();
    private static Dictionary<Type, EShape> calculatorShapes = new();

    internal static CalculatorParameters calcParameters {  get; private set; }
    public static void Setup(CalculatorParameters param)
    {
      calcParameters = param;
      // Initialize Circle Calculator
      calculators.Add(EShape.CIRCLE, new CircleCalculator());
      calculatorShapes.Add(typeof(CircleDesignation), EShape.CIRCLE);
    }

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
      float scalar = MathF.Pow(10, calcParameters.decimalPlaces);

      switch (calcParameters.rounding)
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
