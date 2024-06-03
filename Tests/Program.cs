using ShapeArea.Calculators.Designations;
using System.Diagnostics;

Console.WriteLine("Starting Area Testing");

// Setup Parameters
ShapeArea.ShapeCalculator.Setup(new()
{
  PI = MathF.PI,
  decimalPlaces = 2,
  rounding = ShapeArea.ERounding.TRUNCATE
});

// Assert basic functionality
CircleDesignation circle = new()
{
  radius = 1
};
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 3.14f, "Basic test failed.");
// Test decimal places
ShapeArea.ShapeCalculator.CalcParameters.decimalPlaces = 4;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 3.1415f, "Decimal places test failed.");
// Test rounding up
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.UP;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 3.1416f, "Round up test failed.");
// Test rounding down
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.DOWN;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 3.1415f, "Round down test failed.");
// Test Default rounding
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.DEFAULT;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 3.1416f, "Default Rounding test failed.");
// Test radius
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.TRUNCATE;
circle.radius = 4;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(circle) == 50.2654f, "Radius test failed.");

Console.WriteLine("Tests Passed");