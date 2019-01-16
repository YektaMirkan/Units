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
    /// Test of VitaminA.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VitaminATestsBase
    {
        protected abstract double InternationalUnitsInOneInternationalUnit { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InternationalUnitsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void InternationalUnitToVitaminAUnits()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, VitaminA.From(1, VitaminAUnit.InternationalUnit).InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void As()
        {
            var internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.As(VitaminAUnit.InternationalUnit), InternationalUnitsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var internationalunit = VitaminA.FromInternationalUnits(1);

            var internationalunitQuantity = internationalunit.ToUnit(VitaminAUnit.InternationalUnit);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, (double)internationalunitQuantity.Value, InternationalUnitsTolerance);
            Assert.Equal(VitaminAUnit.InternationalUnit, internationalunitQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(1, VitaminA.FromInternationalUnits(internationalunit.InternationalUnits).InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VitaminA v = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(-1, -v.InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (VitaminA.FromInternationalUnits(3)-v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (v + v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(10, (v*10).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(10, (10*v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (VitaminA.FromInternationalUnits(10)/5).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, VitaminA.FromInternationalUnits(10)/VitaminA.FromInternationalUnits(5), InternationalUnitsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VitaminA oneInternationalUnit = VitaminA.FromInternationalUnits(1);
            VitaminA twoInternationalUnits = VitaminA.FromInternationalUnits(2);

            Assert.True(oneInternationalUnit < twoInternationalUnits);
            Assert.True(oneInternationalUnit <= twoInternationalUnits);
            Assert.True(twoInternationalUnits > oneInternationalUnit);
            Assert.True(twoInternationalUnits >= oneInternationalUnit);

            Assert.False(oneInternationalUnit > twoInternationalUnits);
            Assert.False(oneInternationalUnit >= twoInternationalUnits);
            Assert.False(twoInternationalUnits < oneInternationalUnit);
            Assert.False(twoInternationalUnits <= oneInternationalUnit);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Equal(0, internationalunit.CompareTo(internationalunit));
            Assert.True(internationalunit.CompareTo(VitaminA.Zero) > 0);
            Assert.True(VitaminA.Zero.CompareTo(internationalunit) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentException>(() => internationalunit.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentNullException>(() => internationalunit.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            VitaminA a = VitaminA.FromInternationalUnits(1);
            VitaminA b = VitaminA.FromInternationalUnits(2);

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
            VitaminA v = VitaminA.FromInternationalUnits(1);
            Assert.True(v.Equals(VitaminA.FromInternationalUnits(1), VitaminA.FromInternationalUnits(InternationalUnitsTolerance)));
            Assert.False(v.Equals(VitaminA.Zero, VitaminA.FromInternationalUnits(InternationalUnitsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VitaminAUnit.Undefined, VitaminA.Units);
        }

    }
}