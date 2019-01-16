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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToKinematicViscosity
{
    public static class NumberToKinematicViscosityExtensions
    {
        #region Centistokes

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Centistokes<T>(this T value) => KinematicViscosity.FromCentistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Centistokes<T>(this T? value) where T : struct => KinematicViscosity.FromCentistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decistokes

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Decistokes<T>(this T value) => KinematicViscosity.FromDecistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Decistokes<T>(this T? value) where T : struct => KinematicViscosity.FromDecistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilostokes

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Kilostokes<T>(this T value) => KinematicViscosity.FromKilostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Kilostokes<T>(this T? value) where T : struct => KinematicViscosity.FromKilostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microstokes

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Microstokes<T>(this T value) => KinematicViscosity.FromMicrostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Microstokes<T>(this T? value) where T : struct => KinematicViscosity.FromMicrostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millistokes

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Millistokes<T>(this T value) => KinematicViscosity.FromMillistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Millistokes<T>(this T? value) where T : struct => KinematicViscosity.FromMillistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanostokes

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Nanostokes<T>(this T value) => KinematicViscosity.FromNanostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Nanostokes<T>(this T? value) where T : struct => KinematicViscosity.FromNanostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMeterPerSecond

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(UnitsNet.QuantityValue)" />
        public static KinematicViscosity SquareMetersPerSecond<T>(this T value) => KinematicViscosity.FromSquareMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? SquareMetersPerSecond<T>(this T? value) where T : struct => KinematicViscosity.FromSquareMetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Stokes

        /// <inheritdoc cref="KinematicViscosity.FromStokes(UnitsNet.QuantityValue)" />
        public static KinematicViscosity Stokes<T>(this T value) => KinematicViscosity.FromStokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromStokes(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static KinematicViscosity? Stokes<T>(this T? value) where T : struct => KinematicViscosity.FromStokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif