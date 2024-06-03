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
SphereDesignation sphere = new()
{
  radius = 1
};
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 12.56f, "Basic test failed.");
// Test decimal places
ShapeArea.ShapeCalculator.CalcParameters.decimalPlaces = 4;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 12.5663f, "Decimal places test failed.");
// Test rounding up
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.UP;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 12.5664f, "Round up test failed.");
// Test rounding down
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.DOWN;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 12.5663f, "Round down test failed.");
// Test Default rounding
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.DEFAULT;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 12.5664f, "Default Rounding test failed.");
// Test radius
ShapeArea.ShapeCalculator.CalcParameters.rounding = ShapeArea.ERounding.TRUNCATE;
sphere.radius = 4;
Debug.Assert(ShapeArea.ShapeCalculator.CalculateArea(sphere) == 201.0619f, "Radius test failed.");

Console.WriteLine("Tests Passed");