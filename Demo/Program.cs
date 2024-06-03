using ShapeArea;
using ShapeArea.Calculators.Designations;

bool running = true;
Console.WriteLine();
ShapeCalculator.Setup(new()
{
  PI = MathF.PI,
  decimalPlaces = 2,
  rounding = ERounding.DEFAULT
});
while (running)
{
  Console.WriteLine("Please enter the radius of the circle or type quit to quit: ");
  try
  {
    string? input = Console.ReadLine();
    if (input == null || input == "quit")
    {
      running = false;
      break;
    }
    float radius = Convert.ToSingle(input);
    float area = ShapeCalculator.CalculateArea(new CircleDesignation() { radius = radius });
    Console.WriteLine("The area is " + area + " when rounded to 2 decimal places");
  }
  catch (Exception ex)
  {
    Console.Clear();
    Console.WriteLine("Please enter a number for the radius.");
  }
}