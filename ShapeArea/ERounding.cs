using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
  /// <summary>
  /// Used to determine rounding rules when performing calculations
  /// </summary>
  public enum ERounding
  {
    TRUNCATE, // Truncate
    UP, // Round value up
    DOWN, // Round value down
    DEFAULT // Round like normal (5 up 4 down)
  }
}
