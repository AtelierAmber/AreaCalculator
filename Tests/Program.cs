Console.WriteLine("Starting Area Testing");

// Setup Parameters
ShapeArea.ShapeCalculator.SetupDefaultParameters(new()
{
  PI = MathF.PI,
  decimalPlaces = 2,
  rounding = ShapeArea.ERounding.TRUNCATE
});