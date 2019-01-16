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
namespace UnitsNet.Extensions.NumberToElectricPotentialAc
{
    public static class NumberToElectricPotentialAcExtensions
    {
        #region KilovoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc KilovoltsAc<T>(this T value) => ElectricPotentialAc.FromKilovoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ElectricPotentialAc? KilovoltsAc<T>(this T? value) where T : struct => ElectricPotentialAc.FromKilovoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MegavoltsAc<T>(this T value) => ElectricPotentialAc.FromMegavoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ElectricPotentialAc? MegavoltsAc<T>(this T? value) where T : struct => ElectricPotentialAc.FromMegavoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrovoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MicrovoltsAc<T>(this T value) => ElectricPotentialAc.FromMicrovoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ElectricPotentialAc? MicrovoltsAc<T>(this T? value) where T : struct => ElectricPotentialAc.FromMicrovoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillivoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MillivoltsAc<T>(this T value) => ElectricPotentialAc.FromMillivoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ElectricPotentialAc? MillivoltsAc<T>(this T? value) where T : struct => ElectricPotentialAc.FromMillivoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc VoltsAc<T>(this T value) => ElectricPotentialAc.FromVoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ElectricPotentialAc? VoltsAc<T>(this T? value) where T : struct => ElectricPotentialAc.FromVoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
