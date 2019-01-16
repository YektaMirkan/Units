﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricPotentialAc.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialAcTestsBase
    {
        protected abstract double KilovoltsAcInOneVoltAc { get; }
        protected abstract double MegavoltsAcInOneVoltAc { get; }
        protected abstract double MicrovoltsAcInOneVoltAc { get; }
        protected abstract double MillivoltsAcInOneVoltAc { get; }
        protected abstract double VoltsAcInOneVoltAc { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsAcTolerance { get { return 1e-5; } }
        protected virtual double VoltsAcTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void VoltAcToElectricPotentialAcUnits()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, voltac.KilovoltsAc, KilovoltsAcTolerance);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, voltac.MegavoltsAc, MegavoltsAcTolerance);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, voltac.MicrovoltsAc, MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, voltac.MillivoltsAc, MillivoltsAcTolerance);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, voltac.VoltsAc, VoltsAcTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricPotentialAc.From(1, ElectricPotentialAcUnit.KilovoltAc).KilovoltsAc, KilovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MegavoltAc).MegavoltsAc, MegavoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MicrovoltAc).MicrovoltsAc, MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MillivoltAc).MillivoltsAc, MillivoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.From(1, ElectricPotentialAcUnit.VoltAc).VoltsAc, VoltsAcTolerance);
        }

        [Fact]
        public void As()
        {
            var voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.KilovoltAc), KilovoltsAcTolerance);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MegavoltAc), MegavoltsAcTolerance);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MicrovoltAc), MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MillivoltAc), MillivoltsAcTolerance);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.VoltAc), VoltsAcTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltac = ElectricPotentialAc.FromVoltsAc(1);

            var kilovoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.KilovoltAc);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, (double)kilovoltacQuantity.Value, KilovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.KilovoltAc, kilovoltacQuantity.Unit);

            var megavoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MegavoltAc);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, (double)megavoltacQuantity.Value, MegavoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MegavoltAc, megavoltacQuantity.Unit);

            var microvoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MicrovoltAc);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, (double)microvoltacQuantity.Value, MicrovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MicrovoltAc, microvoltacQuantity.Unit);

            var millivoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MillivoltAc);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, (double)millivoltacQuantity.Value, MillivoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MillivoltAc, millivoltacQuantity.Unit);

            var voltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.VoltAc);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, (double)voltacQuantity.Value, VoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.VoltAc, voltacQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromKilovoltsAc(voltac.KilovoltsAc).VoltsAc, KilovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMegavoltsAc(voltac.MegavoltsAc).VoltsAc, MegavoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMicrovoltsAc(voltac.MicrovoltsAc).VoltsAc, MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMillivoltsAc(voltac.MillivoltsAc).VoltsAc, MillivoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromVoltsAc(voltac.VoltsAc).VoltsAc, VoltsAcTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotentialAc v = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(-1, -v.VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialAc.FromVoltsAc(3)-v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialAc.FromVoltsAc(10)/5).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, ElectricPotentialAc.FromVoltsAc(10)/ElectricPotentialAc.FromVoltsAc(5), VoltsAcTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotentialAc oneVoltAc = ElectricPotentialAc.FromVoltsAc(1);
            ElectricPotentialAc twoVoltsAc = ElectricPotentialAc.FromVoltsAc(2);

            Assert.True(oneVoltAc < twoVoltsAc);
            Assert.True(oneVoltAc <= twoVoltsAc);
            Assert.True(twoVoltsAc > oneVoltAc);
            Assert.True(twoVoltsAc >= oneVoltAc);

            Assert.False(oneVoltAc > twoVoltsAc);
            Assert.False(oneVoltAc >= twoVoltsAc);
            Assert.False(twoVoltsAc < oneVoltAc);
            Assert.False(twoVoltsAc <= oneVoltAc);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Equal(0, voltac.CompareTo(voltac));
            Assert.True(voltac.CompareTo(ElectricPotentialAc.Zero) > 0);
            Assert.True(ElectricPotentialAc.Zero.CompareTo(voltac) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Throws<ArgumentException>(() => voltac.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Throws<ArgumentNullException>(() => voltac.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricPotentialAc a = ElectricPotentialAc.FromVoltsAc(1);
            ElectricPotentialAc b = ElectricPotentialAc.FromVoltsAc(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricPotentialAc v = ElectricPotentialAc.FromVoltsAc(1);
            Assert.True(v.Equals(ElectricPotentialAc.FromVoltsAc(1), ElectricPotentialAc.FromVoltsAc(VoltsAcTolerance)));
            Assert.False(v.Equals(ElectricPotentialAc.Zero, ElectricPotentialAc.FromVoltsAc(VoltsAcTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.False(voltac.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.False(voltac.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricPotentialAcUnit.Undefined, ElectricPotentialAc.Units);
        }

    }
}