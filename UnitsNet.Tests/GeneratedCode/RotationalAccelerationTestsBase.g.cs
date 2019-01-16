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
    /// Test of RotationalAcceleration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalAccelerationTestsBase
    {
        protected abstract double DegreesPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RadiansPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinutePerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void RadianPerSecondSquaredToRotationalAccelerationUnits()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.DegreePerSecondSquared).DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.RadianPerSecondSquared).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.RevolutionPerMinutePerSecond).RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.DegreePerSecondSquared), DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RadianPerSecondSquared), RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RevolutionPerMinutePerSecond), RevolutionsPerMinutePerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);

            var degreepersecondsquaredQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.DegreePerSecondSquared);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, (double)degreepersecondsquaredQuantity.Value, DegreesPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, degreepersecondsquaredQuantity.Unit);

            var radianpersecondsquaredQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.RadianPerSecondSquared);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, (double)radianpersecondsquaredQuantity.Value, RadiansPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, radianpersecondsquaredQuantity.Unit);

            var revolutionperminutepersecondQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.RevolutionPerMinutePerSecond);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, (double)revolutionperminutepersecondQuantity.Value, RevolutionsPerMinutePerSecondTolerance);
            Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, revolutionperminutepersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromDegreesPerSecondSquared(radianpersecondsquared.DegreesPerSecondSquared).RadiansPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRadiansPerSecondSquared(radianpersecondsquared.RadiansPerSecondSquared).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRevolutionsPerMinutePerSecond(radianpersecondsquared.RevolutionsPerMinutePerSecond).RadiansPerSecondSquared, RevolutionsPerMinutePerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalAcceleration v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(3)-v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(10)/5).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, RotationalAcceleration.FromRadiansPerSecondSquared(10)/RotationalAcceleration.FromRadiansPerSecondSquared(5), RadiansPerSecondSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalAcceleration oneRadianPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            RotationalAcceleration twoRadiansPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(2);

            Assert.True(oneRadianPerSecondSquared < twoRadiansPerSecondSquared);
            Assert.True(oneRadianPerSecondSquared <= twoRadiansPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared > oneRadianPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared >= oneRadianPerSecondSquared);

            Assert.False(oneRadianPerSecondSquared > twoRadiansPerSecondSquared);
            Assert.False(oneRadianPerSecondSquared >= twoRadiansPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared < oneRadianPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared <= oneRadianPerSecondSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Equal(0, radianpersecondsquared.CompareTo(radianpersecondsquared));
            Assert.True(radianpersecondsquared.CompareTo(RotationalAcceleration.Zero) > 0);
            Assert.True(RotationalAcceleration.Zero.CompareTo(radianpersecondsquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecondsquared.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            RotationalAcceleration a = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            RotationalAcceleration b = RotationalAcceleration.FromRadiansPerSecondSquared(2);

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
            RotationalAcceleration v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.True(v.Equals(RotationalAcceleration.FromRadiansPerSecondSquared(1), RotationalAcceleration.FromRadiansPerSecondSquared(RadiansPerSecondSquaredTolerance)));
            Assert.False(v.Equals(RotationalAcceleration.Zero, RotationalAcceleration.FromRadiansPerSecondSquared(RadiansPerSecondSquaredTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalAccelerationUnit.Undefined, RotationalAcceleration.Units);
        }

    }
}