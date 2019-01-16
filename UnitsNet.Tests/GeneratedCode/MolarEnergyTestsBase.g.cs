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
    /// Test of MolarEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarEnergyTestsBase
    {
        protected abstract double JoulesPerMoleInOneJoulePerMole { get; }
        protected abstract double KilojoulesPerMoleInOneJoulePerMole { get; }
        protected abstract double MegajoulesPerMoleInOneJoulePerMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerMoleTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void JoulePerMoleToMolarEnergyUnits()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.KilojoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.MegajoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MolarEnergy.From(1, MolarEnergyUnit.JoulePerMole).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.From(1, MolarEnergyUnit.KilojoulePerMole).KilojoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.From(1, MolarEnergyUnit.MegajoulePerMole).MegajoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void As()
        {
            var joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.JoulePerMole), JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.KilojoulePerMole), KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.MegajoulePerMole), MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var joulepermole = MolarEnergy.FromJoulesPerMole(1);

            var joulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.JoulePerMole);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, (double)joulepermoleQuantity.Value, JoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.JoulePerMole, joulepermoleQuantity.Unit);

            var kilojoulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.KilojoulePerMole);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, (double)kilojoulepermoleQuantity.Value, KilojoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.KilojoulePerMole, kilojoulepermoleQuantity.Unit);

            var megajoulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.MegajoulePerMole);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, (double)megajoulepermoleQuantity.Value, MegajoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.MegajoulePerMole, megajoulepermoleQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(1, MolarEnergy.FromJoulesPerMole(joulepermole.JoulesPerMole).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.FromKilojoulesPerMole(joulepermole.KilojoulesPerMole).JoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.FromMegajoulesPerMole(joulepermole.MegajoulesPerMole).JoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MolarEnergy v = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarEnergy.FromJoulesPerMole(3)-v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarEnergy.FromJoulesPerMole(10)/5).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, MolarEnergy.FromJoulesPerMole(10)/MolarEnergy.FromJoulesPerMole(5), JoulesPerMoleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MolarEnergy oneJoulePerMole = MolarEnergy.FromJoulesPerMole(1);
            MolarEnergy twoJoulesPerMole = MolarEnergy.FromJoulesPerMole(2);

            Assert.True(oneJoulePerMole < twoJoulesPerMole);
            Assert.True(oneJoulePerMole <= twoJoulesPerMole);
            Assert.True(twoJoulesPerMole > oneJoulePerMole);
            Assert.True(twoJoulesPerMole >= oneJoulePerMole);

            Assert.False(oneJoulePerMole > twoJoulesPerMole);
            Assert.False(oneJoulePerMole >= twoJoulesPerMole);
            Assert.False(twoJoulesPerMole < oneJoulePerMole);
            Assert.False(twoJoulesPerMole <= oneJoulePerMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Equal(0, joulepermole.CompareTo(joulepermole));
            Assert.True(joulepermole.CompareTo(MolarEnergy.Zero) > 0);
            Assert.True(MolarEnergy.Zero.CompareTo(joulepermole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Throws<ArgumentException>(() => joulepermole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Throws<ArgumentNullException>(() => joulepermole.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            MolarEnergy a = MolarEnergy.FromJoulesPerMole(1);
            MolarEnergy b = MolarEnergy.FromJoulesPerMole(2);

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
            MolarEnergy v = MolarEnergy.FromJoulesPerMole(1);
            Assert.True(v.Equals(MolarEnergy.FromJoulesPerMole(1), MolarEnergy.FromJoulesPerMole(JoulesPerMoleTolerance)));
            Assert.False(v.Equals(MolarEnergy.Zero, MolarEnergy.FromJoulesPerMole(JoulesPerMoleTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarEnergyUnit.Undefined, MolarEnergy.Units);
        }

    }
}
