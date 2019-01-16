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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Heat flux is the flow of energy per unit of area per unit of time
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct HeatFlux : IComparable, IComparable<HeatFlux>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerHourSquareFoot.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromBtusPerHourSquareFoot(QuantityValue? btusperhoursquarefoot)
        {
            return btusperhoursquarefoot.HasValue ? FromBtusPerHourSquareFoot(btusperhoursquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerMinuteSquareFoot.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromBtusPerMinuteSquareFoot(QuantityValue? btusperminutesquarefoot)
        {
            return btusperminutesquarefoot.HasValue ? FromBtusPerMinuteSquareFoot(btusperminutesquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerSecondSquareFoot.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromBtusPerSecondSquareFoot(QuantityValue? btuspersecondsquarefoot)
        {
            return btuspersecondsquarefoot.HasValue ? FromBtusPerSecondSquareFoot(btuspersecondsquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerSecondSquareInch.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromBtusPerSecondSquareInch(QuantityValue? btuspersecondsquareinch)
        {
            return btuspersecondsquareinch.HasValue ? FromBtusPerSecondSquareInch(btuspersecondsquareinch.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable CaloriesPerSecondSquareCentimeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromCaloriesPerSecondSquareCentimeter(QuantityValue? caloriespersecondsquarecentimeter)
        {
            return caloriespersecondsquarecentimeter.HasValue ? FromCaloriesPerSecondSquareCentimeter(caloriespersecondsquarecentimeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable CentiwattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromCentiwattsPerSquareMeter(QuantityValue? centiwattspersquaremeter)
        {
            return centiwattspersquaremeter.HasValue ? FromCentiwattsPerSquareMeter(centiwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable DeciwattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromDeciwattsPerSquareMeter(QuantityValue? deciwattspersquaremeter)
        {
            return deciwattspersquaremeter.HasValue ? FromDeciwattsPerSquareMeter(deciwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilocaloriesPerHourSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromKilocaloriesPerHourSquareMeter(QuantityValue? kilocaloriesperhoursquaremeter)
        {
            return kilocaloriesperhoursquaremeter.HasValue ? FromKilocaloriesPerHourSquareMeter(kilocaloriesperhoursquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromKilocaloriesPerSecondSquareCentimeter(QuantityValue? kilocaloriespersecondsquarecentimeter)
        {
            return kilocaloriespersecondsquarecentimeter.HasValue ? FromKilocaloriesPerSecondSquareCentimeter(kilocaloriespersecondsquarecentimeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilowattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromKilowattsPerSquareMeter(QuantityValue? kilowattspersquaremeter)
        {
            return kilowattspersquaremeter.HasValue ? FromKilowattsPerSquareMeter(kilowattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable MicrowattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromMicrowattsPerSquareMeter(QuantityValue? microwattspersquaremeter)
        {
            return microwattspersquaremeter.HasValue ? FromMicrowattsPerSquareMeter(microwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable MilliwattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromMilliwattsPerSquareMeter(QuantityValue? milliwattspersquaremeter)
        {
            return milliwattspersquaremeter.HasValue ? FromMilliwattsPerSquareMeter(milliwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable NanowattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromNanowattsPerSquareMeter(QuantityValue? nanowattspersquaremeter)
        {
            return nanowattspersquaremeter.HasValue ? FromNanowattsPerSquareMeter(nanowattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable PoundsForcePerFootSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromPoundsForcePerFootSecond(QuantityValue? poundsforceperfootsecond)
        {
            return poundsforceperfootsecond.HasValue ? FromPoundsForcePerFootSecond(poundsforceperfootsecond.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable PoundsPerSecondCubed.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromPoundsPerSecondCubed(QuantityValue? poundspersecondcubed)
        {
            return poundspersecondcubed.HasValue ? FromPoundsPerSecondCubed(poundspersecondcubed.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareFoot.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromWattsPerSquareFoot(QuantityValue? wattspersquarefoot)
        {
            return wattspersquarefoot.HasValue ? FromWattsPerSquareFoot(wattspersquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareInch.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromWattsPerSquareInch(QuantityValue? wattspersquareinch)
        {
            return wattspersquareinch.HasValue ? FromWattsPerSquareInch(wattspersquareinch.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareMeter.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static HeatFlux? FromWattsPerSquareMeter(QuantityValue? wattspersquaremeter)
        {
            return wattspersquaremeter.HasValue ? FromWattsPerSquareMeter(wattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatFluxUnit" /> to <see cref="HeatFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatFlux unit value.</returns>
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static HeatFlux? From(QuantityValue? value, HeatFluxUnit fromUnit)
        {
            return value.HasValue ? new HeatFlux((double)value.Value, fromUnit) : default(HeatFlux?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(HeatFluxUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static HeatFlux operator -(HeatFlux right)
        {
            return new HeatFlux(-right.Value, right.Unit);
        }

        public static HeatFlux operator +(HeatFlux left, HeatFlux right)
        {
            return new HeatFlux(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatFlux operator -(HeatFlux left, HeatFlux right)
        {
            return new HeatFlux(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatFlux operator *(double left, HeatFlux right)
        {
            return new HeatFlux(left * right.Value, right.Unit);
        }

        public static HeatFlux operator *(HeatFlux left, double right)
        {
            return new HeatFlux(left.Value * right, left.Unit);
        }

        public static HeatFlux operator /(HeatFlux left, double right)
        {
            return new HeatFlux(left.Value / right, left.Unit);
        }

        public static double operator /(HeatFlux left, HeatFlux right)
        {
            return left.WattsPerSquareMeter / right.WattsPerSquareMeter;
        }

        #endregion

        public static bool operator <=(HeatFlux left, HeatFlux right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(HeatFlux left, HeatFlux right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(HeatFlux left, HeatFlux right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(HeatFlux left, HeatFlux right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(HeatFlux, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public static bool operator ==(HeatFlux left, HeatFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(HeatFlux, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public static bool operator !=(HeatFlux left, HeatFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static HeatFlux Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<HeatFlux, HeatFluxUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    HeatFluxUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromWattsPerSquareMeter(x.WattsPerSquareMeter + y.WattsPerSquareMeter));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out HeatFlux result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(HeatFlux);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from .NET Framework targets.")]
        public static HeatFluxUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static HeatFluxUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<HeatFluxUnit>(str.Trim());

            if (unit == HeatFluxUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized HeatFluxUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(HeatFluxUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(HeatFluxUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(HeatFluxUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
