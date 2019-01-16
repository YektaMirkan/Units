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
    /// Test of Force.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceTestsBase
    {
        protected abstract double DecanewtonsInOneNewton { get; }
        protected abstract double DyneInOneNewton { get; }
        protected abstract double KilogramsForceInOneNewton { get; }
        protected abstract double KilonewtonsInOneNewton { get; }
        protected abstract double KiloPondsInOneNewton { get; }
        protected abstract double MeganewtonsInOneNewton { get; }
        protected abstract double MicronewtonsInOneNewton { get; }
        protected abstract double MillinewtonsInOneNewton { get; }
        protected abstract double NewtonsInOneNewton { get; }
        protected abstract double OunceForceInOneNewton { get; }
        protected abstract double PoundalsInOneNewton { get; }
        protected abstract double PoundsForceInOneNewton { get; }
        protected abstract double TonnesForceInOneNewton { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecanewtonsTolerance { get { return 1e-5; } }
        protected virtual double DyneTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForceTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsTolerance { get { return 1e-5; } }
        protected virtual double KiloPondsTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsTolerance { get { return 1e-5; } }
        protected virtual double NewtonsTolerance { get { return 1e-5; } }
        protected virtual double OunceForceTolerance { get { return 1e-5; } }
        protected virtual double PoundalsTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceTolerance { get { return 1e-5; } }
        protected virtual double TonnesForceTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonToForceUnits()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.Dyne, DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.Micronewtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.Millinewtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.OunceForce, OunceForceTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.TonnesForce, TonnesForceTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Decanewton).Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Dyn).Dyne, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KilogramForce).KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Kilonewton).Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KiloPond).KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Meganewton).Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Micronewton).Micronewtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Millinewton).Millinewtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Newton).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.OunceForce).OunceForce, OunceForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Poundal).Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.PoundForce).PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.TonneForce).TonnesForce, TonnesForceTolerance);
        }

        [Fact]
        public void As()
        {
            var newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.As(ForceUnit.Decanewton), DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.As(ForceUnit.Dyn), DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.As(ForceUnit.KilogramForce), KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.As(ForceUnit.Kilonewton), KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.As(ForceUnit.KiloPond), KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.As(ForceUnit.Meganewton), MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.As(ForceUnit.Micronewton), MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.As(ForceUnit.Millinewton), MillinewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.As(ForceUnit.Newton), NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.As(ForceUnit.OunceForce), OunceForceTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.As(ForceUnit.Poundal), PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.As(ForceUnit.PoundForce), PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.As(ForceUnit.TonneForce), TonnesForceTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newton = Force.FromNewtons(1);

            var decanewtonQuantity = newton.ToUnit(ForceUnit.Decanewton);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, (double)decanewtonQuantity.Value, DecanewtonsTolerance);
            Assert.Equal(ForceUnit.Decanewton, decanewtonQuantity.Unit);

            var dynQuantity = newton.ToUnit(ForceUnit.Dyn);
            AssertEx.EqualTolerance(DyneInOneNewton, (double)dynQuantity.Value, DyneTolerance);
            Assert.Equal(ForceUnit.Dyn, dynQuantity.Unit);

            var kilogramforceQuantity = newton.ToUnit(ForceUnit.KilogramForce);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, (double)kilogramforceQuantity.Value, KilogramsForceTolerance);
            Assert.Equal(ForceUnit.KilogramForce, kilogramforceQuantity.Unit);

            var kilonewtonQuantity = newton.ToUnit(ForceUnit.Kilonewton);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, (double)kilonewtonQuantity.Value, KilonewtonsTolerance);
            Assert.Equal(ForceUnit.Kilonewton, kilonewtonQuantity.Unit);

            var kilopondQuantity = newton.ToUnit(ForceUnit.KiloPond);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, (double)kilopondQuantity.Value, KiloPondsTolerance);
            Assert.Equal(ForceUnit.KiloPond, kilopondQuantity.Unit);

            var meganewtonQuantity = newton.ToUnit(ForceUnit.Meganewton);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, (double)meganewtonQuantity.Value, MeganewtonsTolerance);
            Assert.Equal(ForceUnit.Meganewton, meganewtonQuantity.Unit);

            var micronewtonQuantity = newton.ToUnit(ForceUnit.Micronewton);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, (double)micronewtonQuantity.Value, MicronewtonsTolerance);
            Assert.Equal(ForceUnit.Micronewton, micronewtonQuantity.Unit);

            var millinewtonQuantity = newton.ToUnit(ForceUnit.Millinewton);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, (double)millinewtonQuantity.Value, MillinewtonsTolerance);
            Assert.Equal(ForceUnit.Millinewton, millinewtonQuantity.Unit);

            var newtonQuantity = newton.ToUnit(ForceUnit.Newton);
            AssertEx.EqualTolerance(NewtonsInOneNewton, (double)newtonQuantity.Value, NewtonsTolerance);
            Assert.Equal(ForceUnit.Newton, newtonQuantity.Unit);

            var ounceforceQuantity = newton.ToUnit(ForceUnit.OunceForce);
            AssertEx.EqualTolerance(OunceForceInOneNewton, (double)ounceforceQuantity.Value, OunceForceTolerance);
            Assert.Equal(ForceUnit.OunceForce, ounceforceQuantity.Unit);

            var poundalQuantity = newton.ToUnit(ForceUnit.Poundal);
            AssertEx.EqualTolerance(PoundalsInOneNewton, (double)poundalQuantity.Value, PoundalsTolerance);
            Assert.Equal(ForceUnit.Poundal, poundalQuantity.Unit);

            var poundforceQuantity = newton.ToUnit(ForceUnit.PoundForce);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, (double)poundforceQuantity.Value, PoundsForceTolerance);
            Assert.Equal(ForceUnit.PoundForce, poundforceQuantity.Unit);

            var tonneforceQuantity = newton.ToUnit(ForceUnit.TonneForce);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, (double)tonneforceQuantity.Value, TonnesForceTolerance);
            Assert.Equal(ForceUnit.TonneForce, tonneforceQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(1, Force.FromDecanewtons(newton.Decanewtons).Newtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDyne(newton.Dyne).Newtons, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilogramsForce(newton.KilogramsForce).Newtons, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilonewtons(newton.Kilonewtons).Newtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKiloPonds(newton.KiloPonds).Newtons, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMeganewtons(newton.Meganewtons).Newtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMicronewtons(newton.Micronewtons).Newtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMillinewtons(newton.Millinewtons).Newtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromNewtons(newton.Newtons).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromOunceForce(newton.OunceForce).Newtons, OunceForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundals(newton.Poundals).Newtons, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundsForce(newton.PoundsForce).Newtons, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromTonnesForce(newton.TonnesForce).Newtons, TonnesForceTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Force v = Force.FromNewtons(1);
            AssertEx.EqualTolerance(-1, -v.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(3)-v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(10)/5).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, Force.FromNewtons(10)/Force.FromNewtons(5), NewtonsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Force oneNewton = Force.FromNewtons(1);
            Force twoNewtons = Force.FromNewtons(2);

            Assert.True(oneNewton < twoNewtons);
            Assert.True(oneNewton <= twoNewtons);
            Assert.True(twoNewtons > oneNewton);
            Assert.True(twoNewtons >= oneNewton);

            Assert.False(oneNewton > twoNewtons);
            Assert.False(oneNewton >= twoNewtons);
            Assert.False(twoNewtons < oneNewton);
            Assert.False(twoNewtons <= oneNewton);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Equal(0, newton.CompareTo(newton));
            Assert.True(newton.CompareTo(Force.Zero) > 0);
            Assert.True(Force.Zero.CompareTo(newton) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentException>(() => newton.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentNullException>(() => newton.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Force a = Force.FromNewtons(1);
            Force b = Force.FromNewtons(2);

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
            Force v = Force.FromNewtons(1);
            Assert.True(v.Equals(Force.FromNewtons(1), Force.FromNewtons(NewtonsTolerance)));
            Assert.False(v.Equals(Force.Zero, Force.FromNewtons(NewtonsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForceUnit.Undefined, Force.Units);
        }

    }
}