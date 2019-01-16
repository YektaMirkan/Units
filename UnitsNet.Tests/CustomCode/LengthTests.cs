﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Xunit;
using UnitsNet.Units;

namespace UnitsNet.Tests.CustomCode
{
    // Avoid accessing static prop DefaultToString in parallel from multiple tests:
    // UnitSystemTests.DefaultToStringFormatting()
    // LengthTests.ToStringReturnsCorrectNumberAndUnitWithCentimeterAsDefualtUnit()
    [Collection(nameof(UnitSystemFixture))]
    public class LengthTests : LengthTestsBase
    {
        protected override double CentimetersInOneMeter => 100;

        protected override double DecimetersInOneMeter => 10;
        protected override double DtpPicasInOneMeter => 236.22047244;
        protected override double DtpPointsInOneMeter => 2834.6456693;

        protected override double FeetInOneMeter => 3.28084;

        protected override double TwipsInOneMeter => 56692.913386;
        protected override double UsSurveyFeetInOneMeter => 3.280833333333333;

        protected override double InchesInOneMeter => 39.37007874;

        protected override double KilometersInOneMeter => 1E-3;

        protected override double MetersInOneMeter => 1;

        protected override double MicroinchesInOneMeter => 39370078.74015748;

        protected override double MicrometersInOneMeter => 1E6;

        protected override double MilsInOneMeter => 39370.07874015;

        protected override double MilesInOneMeter => 0.000621371;

        protected override double MillimetersInOneMeter => 1E3;

        protected override double NanometersInOneMeter => 1E9;

        protected override double YardsInOneMeter => 1.09361;
      
        protected override double FathomsInOneMeter => 0.546806649;

        protected override double PrinterPicasInOneMeter => 237.10630158;
        protected override double PrinterPointsInOneMeter => 2845.2755906;

        protected override double ShacklesInOneMeter => 0.0364538;

        protected override double NauticalMilesInOneMeter => 1.0/1852.0;

        [Fact]
        public void AreaTimesLengthEqualsVolume()
        {
            Volume volume = Area.FromSquareMeters(10)*Length.FromMeters(3);
            Assert.Equal(volume, Volume.FromCubicMeters(30));
        }

        [Fact]
        public void ForceTimesLengthEqualsTorque()
        {
            Torque torque = Force.FromNewtons(1)*Length.FromMeters(3);
            Assert.Equal(torque, Torque.FromNewtonMeters(3));
        }

        [Fact]
        public void LengthTimesAreaEqualsVolume()
        {
            Volume volume = Length.FromMeters(3)*Area.FromSquareMeters(9);
            Assert.Equal(volume, Volume.FromCubicMeters(27));
        }

        [Fact]
        public void LengthTimesForceEqualsTorque()
        {
            Torque torque = Length.FromMeters(3)*Force.FromNewtons(1);
            Assert.Equal(torque, Torque.FromNewtonMeters(3));
        }

        [Fact]
        public void LengthTimesLengthEqualsArea()
        {
            Area area = Length.FromMeters(10)*Length.FromMeters(2);
            Assert.Equal(area, Area.FromSquareMeters(20));
        }

        [Fact]
        public void LengthDividedBySpeedEqualsDuration()
        {
            Duration duration = Length.FromMeters(20) / Speed.FromMetersPerSecond(2);
            Assert.Equal(Duration.FromSeconds(10), duration);
        }

        [Fact]
        public void LengthTimesSpeedEqualsKinematicViscosity()
        {
            KinematicViscosity kinematicViscosity = Length.FromMeters(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(KinematicViscosity.FromSquareMetersPerSecond(40), kinematicViscosity);
        }

        [Fact]
        public void LengthTimesSpecificWeightEqualsPressure()
        {
            Pressure pressure = Length.FromMeters(2) * SpecificWeight.FromNewtonsPerCubicMeter(10);
            Assert.Equal(Pressure.FromPascals(20), pressure);
        }

        [Fact]
        public void ToStringReturnsCorrectNumberAndUnitWithDefaultUnitWhichIsMeter()
        {
            LengthUnit oldUnit = Length.ToStringDefaultUnit;
            Length.ToStringDefaultUnit = LengthUnit.Meter;
            Length meter = Length.FromMeters(5);
            string meterString = meter.ToString();
            Length.ToStringDefaultUnit = oldUnit;
            Assert.Equal("5 m", meterString);
        }

        [Fact]
        public void ToStringReturnsCorrectNumberAndUnitWithCentimeterAsDefualtUnit()
        {
            LengthUnit oldUnit = Length.ToStringDefaultUnit;
            Length.ToStringDefaultUnit = LengthUnit.Centimeter;
            Length value = Length.From(2, LengthUnit.Centimeter);
            string valueString = value.ToString();
            Length.ToStringDefaultUnit = oldUnit;
            Assert.Equal("2 cm", valueString);
        }

        [Fact]
        public void MaxValueIsCorrectForUnitWithBaseTypeDouble()
        {
            Assert.Equal(double.MaxValue, Length.MaxValue.Meters);
        }

        [Fact]
        public void MinValueIsCorrectForUnitWithBaseTypeDouble()
        {
            Assert.Equal(double.MinValue, Length.MinValue.Meters);
        }

        
    }
}
