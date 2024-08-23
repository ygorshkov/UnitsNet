//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToPower
{
    /// <summary>
    /// A number to Power Extensions
    /// </summary>
    public static class NumberToPowerExtensions
    {
        /// <inheritdoc cref="Power.FromBoilerHorsepower(UnitsNet.QuantityValue)" />
        public static Power BoilerHorsepower<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromBoilerHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(UnitsNet.QuantityValue)" />
        public static Power BritishThermalUnitsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromBritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDecawatts(UnitsNet.QuantityValue)" />
        public static Power Decawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromDecawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDeciwatts(UnitsNet.QuantityValue)" />
        public static Power Deciwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromDeciwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromElectricalHorsepower(UnitsNet.QuantityValue)" />
        public static Power ElectricalHorsepower<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromElectricalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromFemtowatts(UnitsNet.QuantityValue)" />
        public static Power Femtowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromFemtowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromGigajoulesPerHour(UnitsNet.QuantityValue)" />
        public static Power GigajoulesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromGigajoulesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromGigawatts(UnitsNet.QuantityValue)" />
        public static Power Gigawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromGigawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(UnitsNet.QuantityValue)" />
        public static Power HydraulicHorsepower<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromHydraulicHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromJoulesPerHour(UnitsNet.QuantityValue)" />
        public static Power JoulesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromJoulesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(UnitsNet.QuantityValue)" />
        public static Power KilobritishThermalUnitsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromKilobritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilojoulesPerHour(UnitsNet.QuantityValue)" />
        public static Power KilojoulesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromKilojoulesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilowatts(UnitsNet.QuantityValue)" />
        public static Power Kilowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromKilowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(UnitsNet.QuantityValue)" />
        public static Power MechanicalHorsepower<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMechanicalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMegabritishThermalUnitsPerHour(UnitsNet.QuantityValue)" />
        public static Power MegabritishThermalUnitsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMegabritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMegajoulesPerHour(UnitsNet.QuantityValue)" />
        public static Power MegajoulesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMegajoulesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMegawatts(UnitsNet.QuantityValue)" />
        public static Power Megawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMegawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMetricHorsepower(UnitsNet.QuantityValue)" />
        public static Power MetricHorsepower<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMetricHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMicrowatts(UnitsNet.QuantityValue)" />
        public static Power Microwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMicrowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMillijoulesPerHour(UnitsNet.QuantityValue)" />
        public static Power MillijoulesPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMillijoulesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMilliwatts(UnitsNet.QuantityValue)" />
        public static Power Milliwatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromMilliwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromNanowatts(UnitsNet.QuantityValue)" />
        public static Power Nanowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromNanowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPetawatts(UnitsNet.QuantityValue)" />
        public static Power Petawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromPetawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPicowatts(UnitsNet.QuantityValue)" />
        public static Power Picowatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromPicowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromTerawatts(UnitsNet.QuantityValue)" />
        public static Power Terawatts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromTerawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromTonsOfRefrigeration(UnitsNet.QuantityValue)" />
        public static Power TonsOfRefrigeration<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromTonsOfRefrigeration(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromWatts(UnitsNet.QuantityValue)" />
        public static Power Watts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Power.FromWatts(Convert.ToDouble(value));

    }
}
