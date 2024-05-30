namespace ShapeArea
{
  public static class ShapeCalculator
  {
    private static Dictionary<EShape, ICalculator> calculators = new();

    private static CalculatorParameters areaParameters;
    public static void Setup(CalculatorParameters param)
    {
      areaParameters = param;

      // Setup Circle Calculator

    }

    

  }
}
