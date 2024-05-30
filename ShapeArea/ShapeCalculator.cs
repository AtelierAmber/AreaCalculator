using ShapeArea.Calculators;

namespace ShapeArea
{
  public static class ShapeCalculator
  {
    private static Dictionary<EShape, ICalculator> calculators = new();

    internal static CalculatorParameters areaParameters {  get; private set; }
    public static void Setup(CalculatorParameters param)
    {
      areaParameters = param;
      // Initialize Circle Calculator
      calculators.Add(EShape.CIRCLE, new CircleCalculator());
    }
  }
}
