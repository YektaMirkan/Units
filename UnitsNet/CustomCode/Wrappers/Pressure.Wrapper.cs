using System;
using System.Collections.Generic;
using System.Linq;
using UnitsNet.Units;

namespace UnitsNet.CustomCode.Wrappers
{
    public struct ReferencePressure
    {
        public ReferencePressure(Pressure pressure, PressureReference reference)
        {
            _reference = reference;
            Pressure = pressure;
        }

        public ReferencePressure(Pressure pressure)
        {
            _reference = BaseReference;
            Pressure = pressure;
        }

        public PressureReference Reference => _reference.GetValueOrDefault(BaseReference);

        /// <summary>
        ///     The measured reference this quantity was constructed with.
        /// </summary>
        private readonly PressureReference? _reference;

        public static List<PressureReference> References { get; } = Enum.GetValues(typeof(PressureReference)).Cast<PressureReference>().Except(new[] { PressureReference.Undefined }).ToList();


        /// <summary>
        ///     The base reference representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static PressureReference BaseReference { get; } = PressureReference.Absolute;

        private Pressure Pressure { get; }

        /// <summary>
        ///     Get Gauge Pressure.
        ///     It refers pressure level above Reference Pressure.
        /// </summary>
        public Pressure Gauge => As(PressureReference.Gauge);

        /// <summary>
        ///     Get Absolute Pressure.
        ///     It is zero-referenced pressure to the perfect vacuum.
        /// </summary>
        public Pressure Absolute => As(PressureReference.Absolute);

        /// <summary>
        ///     Get Vacuum Pressure.
        ///     It is a negative Gauge Pressure when Absolute Pressure is below Reference Pressure.
        /// </summary>
        public Pressure Vacuum => As(PressureReference.Vacuum);


        private Pressure As(PressureReference reference)
        {
            if (Reference == reference)
                return new Pressure(Pressure.Value, Pressure.Unit);

            var converted = AsBaseNumericType(reference);

            if (converted < 0) converted *= -1;
            return new Pressure(converted, Pressure.Unit);
        }

        private double AsBaseNumericType(PressureReference reference)
        {
            if (Reference == reference)
                return Pressure.Value;

            var baseReferenceValue = AsBaseReference();
            var negatingValue = Reference == PressureReference.Vacuum ? -1 : 1 ;
            
            switch (reference)
            {
                case PressureReference.Absolute: return baseReferenceValue;
                case PressureReference.Gauge: return baseReferenceValue - ReferencedPressure.ToUnit(Pressure.Unit).Value;
                case PressureReference.Vacuum: return ReferencedPressure.ToUnit(Pressure.Unit).Value - negatingValue * baseReferenceValue;
                default:
                    throw new NotImplementedException($"Can not convert {Reference} to {reference}.");
            }
        }

        private double AsBaseReference()
        {
            switch (Reference)
            {
                case PressureReference.Absolute: return Pressure.Value;
                case PressureReference.Gauge: return ReferencedPressure.ToUnit(Pressure.Unit).Value + Pressure.Value;
                case PressureReference.Vacuum: return ReferencedPressure.ToUnit(Pressure.Unit).Value - Pressure.Value;
                default:
                    throw new NotImplementedException($"Can not convert {Reference} to base reference.");
            }
        }

        public static Pressure ReferencedPressure { get; set; } = new Pressure(1, PressureUnit.Atmosphere);
    }
}
