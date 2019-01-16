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
using UnitsNet.CustomCode.Extensions;

namespace UnitsNet.Tests.CustomCode
{
    public class AmplitudeRatioTests : AmplitudeRatioTestsBase
    {
        protected override double DecibelMicrovoltsInOneDecibelVolt => 121;

        protected override double DecibelMillivoltsInOneDecibelVolt => 61;

        protected override double DecibelsUnloadedInOneDecibelVolt => 3.218487499;

        protected override double DecibelVoltsInOneDecibelVolt => 1;

        protected override void AssertLogarithmicAddition()
        {
            AmplitudeRatio v = AmplitudeRatio.FromDecibelVolts(40);
            AssertEx.EqualTolerance(46.0205999133, (v + v).DecibelVolts, DecibelVoltsTolerance);
        }

        protected override void AssertLogarithmicSubtraction()
        {
            AmplitudeRatio v = AmplitudeRatio.FromDecibelVolts(40);
            AssertEx.EqualTolerance(46.6982292275, (AmplitudeRatio.FromDecibelVolts(50) - v).DecibelVolts, DecibelVoltsTolerance);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        public void InvalidVoltage_ExpectArgumentOutOfRangeException(double voltage)
        {
            ElectricPotential invalidVoltage = ElectricPotential.FromVolts(voltage);

            // ReSharper disable once ObjectCreationAsStatement
            Assert.Throws<ArgumentOutOfRangeException>(() => new AmplitudeRatio(invalidVoltage));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(10, 20)]
        [InlineData(100, 40)]
        [InlineData(1000, 60)]
        public void ExpectVoltageConvertedToAmplitudeRatioCorrectly(double voltage, double expected)
        {
            // Amplitude ratio increases linearly by 20 dBV with power-of-10 increases of voltage.
            ElectricPotential v = ElectricPotential.FromVolts(voltage);

            double actual = AmplitudeRatio.FromElectricPotential(v).DecibelVolts;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-40, 0.01)]
        [InlineData(-20, 0.1)]
        [InlineData(0, 1)]
        [InlineData(20, 10)]
        [InlineData(40, 100)]
        public void ExpectAmplitudeRatioConvertedToVoltageCorrectly(double amplitudeRatio, double expected)
        {
            // Voltage increases by powers of 10 for every 20 dBV increase in amplitude ratio.
            AmplitudeRatio ar = AmplitudeRatio.FromDecibelVolts(amplitudeRatio);

            double actual = AmplitudeRatio.ToElectricPotential(ar).Volts;
            Assert.Equal(expected, actual);
        }

        // http://www.maximintegrated.com/en/app-notes/index.mvp/id/808

        [Theory]
        [InlineData(8, -38.99)]
        [InlineData(20, -26.99)]
        [InlineData(40, -6.99)]
        [InlineData(60, 13.01)]
        public void AmplitudeRatioToPowerRatio_50OhmImpedance(double dBmV, double expected)
        {
            AmplitudeRatio ampRatio = AmplitudeRatio.FromDecibelMillivolts(dBmV);

            double actual = Math.Round(ampRatio.ToPowerRatio(ElectricResistance.FromOhms(50)).DecibelMilliwatts, 2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, -40.75)]
        [InlineData(20, -28.75)]
        [InlineData(40, -8.75)]
        [InlineData(60, 11.25)]
        public void AmplitudeRatioToPowerRatio_75OhmImpedance(double dBmV, double expected)
        {
            AmplitudeRatio ampRatio = AmplitudeRatio.FromDecibelMillivolts(dBmV);

            double actual = Math.Round(ampRatio.ToPowerRatio(ElectricResistance.FromOhms(75)).DecibelMilliwatts, 2);
            Assert.Equal(expected, actual);
        }
    }
}