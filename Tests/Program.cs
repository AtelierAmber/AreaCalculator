Console.WriteLine("Starting Area Testing");

// Setup Parameters
ShapeArea.ShapeCalculator.Setup(new()
{
  PI = MathF.PI,
  decimalPlaces = 2,
  rounding = ShapeArea.ERounding.TRUNCATE
});