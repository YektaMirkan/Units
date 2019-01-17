using System;
using System.Collections.Generic;
using System.Text;
using UnitsNet.Units;

namespace UnitsNet.CustomCode.Extensions
{
    public static class PressureExtensions
    {
        public static Pressure AsGauge(this Pressure pressure)
        {
            PressureUnit selectedUnit = pressure.Unit;
            double value = pressure.As(selectedUnit) - Pressure.Reference.ToUnit(selectedUnit).Value;

            return new Pressure(value, selectedUnit);
        }
    }
}
