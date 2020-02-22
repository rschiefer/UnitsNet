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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LinearDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LinearDensityTestsBase
    {
        protected abstract double GramsPerCentimeterInOneKilogramPerMeter { get; }
        protected abstract double GramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double GramsPerMillimeterInOneKilogramPerMeter { get; }
        protected abstract double KilogramsPerCentimeterInOneKilogramPerMeter { get; }
        protected abstract double KilogramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double KilogramsPerMillimeterInOneKilogramPerMeter { get; }
        protected abstract double MicrogramsPerCentimeterInOneKilogramPerMeter { get; }
        protected abstract double MicrogramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double MicrogramsPerMillimeterInOneKilogramPerMeter { get; }
        protected abstract double MilligramsPerCentimeterInOneKilogramPerMeter { get; }
        protected abstract double MilligramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double MilligramsPerMillimeterInOneKilogramPerMeter { get; }
        protected abstract double PoundsPerFootInOneKilogramPerMeter { get; }
        protected abstract double PoundsPerInchInOneKilogramPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerCentimeterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerMillimeterTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerCentimeterTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerMillimeterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerCentimeterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerMillimeterTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerInchTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LinearDensity((double)0.0, LinearDensityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LinearDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LinearDensityUnit.KilogramPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LinearDensity(double.PositiveInfinity, LinearDensityUnit.KilogramPerMeter));
            Assert.Throws<ArgumentException>(() => new LinearDensity(double.NegativeInfinity, LinearDensityUnit.KilogramPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LinearDensity(double.NaN, LinearDensityUnit.KilogramPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LinearDensity(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void LinearDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LinearDensity(1, LinearDensityUnit.KilogramPerMeter);

            QuantityInfo<LinearDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LinearDensity.Zero, quantityInfo.Zero);
            Assert.Equal("LinearDensity", quantityInfo.Name);
            Assert.Equal(QuantityType.LinearDensity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<LinearDensityUnit>().Except(new[] {LinearDensityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KilogramPerMeterToLinearDensityUnits()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(GramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.GramsPerCentimeter, GramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, kilogrampermeter.GramsPerMeter, GramsPerMeterTolerance);
            AssertEx.EqualTolerance(GramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.GramsPerMillimeter, GramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.KilogramsPerCentimeter, KilogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.KilogramsPerMillimeter, KilogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.MicrogramsPerCentimeter, MicrogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.MicrogramsPerMeter, MicrogramsPerMeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.MicrogramsPerMillimeter, MicrogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.MilligramsPerCentimeter, MilligramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMeterInOneKilogramPerMeter, kilogrampermeter.MilligramsPerMeter, MilligramsPerMeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.MilligramsPerMillimeter, MilligramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, kilogrampermeter.PoundsPerFoot, PoundsPerFootTolerance);
            AssertEx.EqualTolerance(PoundsPerInchInOneKilogramPerMeter, kilogrampermeter.PoundsPerInch, PoundsPerInchTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LinearDensity.From(1, LinearDensityUnit.GramPerCentimeter);
            AssertEx.EqualTolerance(1, quantity00.GramsPerCentimeter, GramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerCentimeter, quantity00.Unit);

            var quantity01 = LinearDensity.From(1, LinearDensityUnit.GramPerMeter);
            AssertEx.EqualTolerance(1, quantity01.GramsPerMeter, GramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerMeter, quantity01.Unit);

            var quantity02 = LinearDensity.From(1, LinearDensityUnit.GramPerMillimeter);
            AssertEx.EqualTolerance(1, quantity02.GramsPerMillimeter, GramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerMillimeter, quantity02.Unit);

            var quantity03 = LinearDensity.From(1, LinearDensityUnit.KilogramPerCentimeter);
            AssertEx.EqualTolerance(1, quantity03.KilogramsPerCentimeter, KilogramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerCentimeter, quantity03.Unit);

            var quantity04 = LinearDensity.From(1, LinearDensityUnit.KilogramPerMeter);
            AssertEx.EqualTolerance(1, quantity04.KilogramsPerMeter, KilogramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerMeter, quantity04.Unit);

            var quantity05 = LinearDensity.From(1, LinearDensityUnit.KilogramPerMillimeter);
            AssertEx.EqualTolerance(1, quantity05.KilogramsPerMillimeter, KilogramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerMillimeter, quantity05.Unit);

            var quantity06 = LinearDensity.From(1, LinearDensityUnit.MicrogramPerCentimeter);
            AssertEx.EqualTolerance(1, quantity06.MicrogramsPerCentimeter, MicrogramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerCentimeter, quantity06.Unit);

            var quantity07 = LinearDensity.From(1, LinearDensityUnit.MicrogramPerMeter);
            AssertEx.EqualTolerance(1, quantity07.MicrogramsPerMeter, MicrogramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerMeter, quantity07.Unit);

            var quantity08 = LinearDensity.From(1, LinearDensityUnit.MicrogramPerMillimeter);
            AssertEx.EqualTolerance(1, quantity08.MicrogramsPerMillimeter, MicrogramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerMillimeter, quantity08.Unit);

            var quantity09 = LinearDensity.From(1, LinearDensityUnit.MilligramPerCentimeter);
            AssertEx.EqualTolerance(1, quantity09.MilligramsPerCentimeter, MilligramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerCentimeter, quantity09.Unit);

            var quantity10 = LinearDensity.From(1, LinearDensityUnit.MilligramPerMeter);
            AssertEx.EqualTolerance(1, quantity10.MilligramsPerMeter, MilligramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerMeter, quantity10.Unit);

            var quantity11 = LinearDensity.From(1, LinearDensityUnit.MilligramPerMillimeter);
            AssertEx.EqualTolerance(1, quantity11.MilligramsPerMillimeter, MilligramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerMillimeter, quantity11.Unit);

            var quantity12 = LinearDensity.From(1, LinearDensityUnit.PoundPerFoot);
            AssertEx.EqualTolerance(1, quantity12.PoundsPerFoot, PoundsPerFootTolerance);
            Assert.Equal(LinearDensityUnit.PoundPerFoot, quantity12.Unit);

            var quantity13 = LinearDensity.From(1, LinearDensityUnit.PoundPerInch);
            AssertEx.EqualTolerance(1, quantity13.PoundsPerInch, PoundsPerInchTolerance);
            Assert.Equal(LinearDensityUnit.PoundPerInch, quantity13.Unit);

        }

        [Fact]
        public void FromKilogramsPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LinearDensity.FromKilogramsPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LinearDensity.FromKilogramsPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LinearDensity.FromKilogramsPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(GramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.GramPerCentimeter), GramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.GramPerMeter), GramsPerMeterTolerance);
            AssertEx.EqualTolerance(GramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.GramPerMillimeter), GramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.KilogramPerCentimeter), KilogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.KilogramPerMeter), KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.KilogramPerMillimeter), KilogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MicrogramPerCentimeter), MicrogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MicrogramPerMeter), MicrogramsPerMeterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MicrogramPerMillimeter), MicrogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerCentimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MilligramPerCentimeter), MilligramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MilligramPerMeter), MilligramsPerMeterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMillimeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.MilligramPerMillimeter), MilligramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.PoundPerFoot), PoundsPerFootTolerance);
            AssertEx.EqualTolerance(PoundsPerInchInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.PoundPerInch), PoundsPerInchTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);

            var grampercentimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.GramPerCentimeter);
            AssertEx.EqualTolerance(GramsPerCentimeterInOneKilogramPerMeter, (double)grampercentimeterQuantity.Value, GramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerCentimeter, grampercentimeterQuantity.Unit);

            var grampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.GramPerMeter);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, (double)grampermeterQuantity.Value, GramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerMeter, grampermeterQuantity.Unit);

            var grampermillimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.GramPerMillimeter);
            AssertEx.EqualTolerance(GramsPerMillimeterInOneKilogramPerMeter, (double)grampermillimeterQuantity.Value, GramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerMillimeter, grampermillimeterQuantity.Unit);

            var kilogrampercentimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.KilogramPerCentimeter);
            AssertEx.EqualTolerance(KilogramsPerCentimeterInOneKilogramPerMeter, (double)kilogrampercentimeterQuantity.Value, KilogramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerCentimeter, kilogrampercentimeterQuantity.Unit);

            var kilogrampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.KilogramPerMeter);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, (double)kilogrampermeterQuantity.Value, KilogramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerMeter, kilogrampermeterQuantity.Unit);

            var kilogrampermillimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.KilogramPerMillimeter);
            AssertEx.EqualTolerance(KilogramsPerMillimeterInOneKilogramPerMeter, (double)kilogrampermillimeterQuantity.Value, KilogramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerMillimeter, kilogrampermillimeterQuantity.Unit);

            var microgrampercentimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MicrogramPerCentimeter);
            AssertEx.EqualTolerance(MicrogramsPerCentimeterInOneKilogramPerMeter, (double)microgrampercentimeterQuantity.Value, MicrogramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerCentimeter, microgrampercentimeterQuantity.Unit);

            var microgrampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MicrogramPerMeter);
            AssertEx.EqualTolerance(MicrogramsPerMeterInOneKilogramPerMeter, (double)microgrampermeterQuantity.Value, MicrogramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerMeter, microgrampermeterQuantity.Unit);

            var microgrampermillimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MicrogramPerMillimeter);
            AssertEx.EqualTolerance(MicrogramsPerMillimeterInOneKilogramPerMeter, (double)microgrampermillimeterQuantity.Value, MicrogramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.MicrogramPerMillimeter, microgrampermillimeterQuantity.Unit);

            var milligrampercentimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MilligramPerCentimeter);
            AssertEx.EqualTolerance(MilligramsPerCentimeterInOneKilogramPerMeter, (double)milligrampercentimeterQuantity.Value, MilligramsPerCentimeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerCentimeter, milligrampercentimeterQuantity.Unit);

            var milligrampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MilligramPerMeter);
            AssertEx.EqualTolerance(MilligramsPerMeterInOneKilogramPerMeter, (double)milligrampermeterQuantity.Value, MilligramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerMeter, milligrampermeterQuantity.Unit);

            var milligrampermillimeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.MilligramPerMillimeter);
            AssertEx.EqualTolerance(MilligramsPerMillimeterInOneKilogramPerMeter, (double)milligrampermillimeterQuantity.Value, MilligramsPerMillimeterTolerance);
            Assert.Equal(LinearDensityUnit.MilligramPerMillimeter, milligrampermillimeterQuantity.Unit);

            var poundperfootQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.PoundPerFoot);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, (double)poundperfootQuantity.Value, PoundsPerFootTolerance);
            Assert.Equal(LinearDensityUnit.PoundPerFoot, poundperfootQuantity.Unit);

            var poundperinchQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.PoundPerInch);
            AssertEx.EqualTolerance(PoundsPerInchInOneKilogramPerMeter, (double)poundperinchQuantity.Value, PoundsPerInchTolerance);
            Assert.Equal(LinearDensityUnit.PoundPerInch, poundperinchQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(1, LinearDensity.FromGramsPerCentimeter(kilogrampermeter.GramsPerCentimeter).KilogramsPerMeter, GramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromGramsPerMeter(kilogrampermeter.GramsPerMeter).KilogramsPerMeter, GramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromGramsPerMillimeter(kilogrampermeter.GramsPerMillimeter).KilogramsPerMeter, GramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromKilogramsPerCentimeter(kilogrampermeter.KilogramsPerCentimeter).KilogramsPerMeter, KilogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromKilogramsPerMeter(kilogrampermeter.KilogramsPerMeter).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromKilogramsPerMillimeter(kilogrampermeter.KilogramsPerMillimeter).KilogramsPerMeter, KilogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMicrogramsPerCentimeter(kilogrampermeter.MicrogramsPerCentimeter).KilogramsPerMeter, MicrogramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMicrogramsPerMeter(kilogrampermeter.MicrogramsPerMeter).KilogramsPerMeter, MicrogramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMicrogramsPerMillimeter(kilogrampermeter.MicrogramsPerMillimeter).KilogramsPerMeter, MicrogramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMilligramsPerCentimeter(kilogrampermeter.MilligramsPerCentimeter).KilogramsPerMeter, MilligramsPerCentimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMilligramsPerMeter(kilogrampermeter.MilligramsPerMeter).KilogramsPerMeter, MilligramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromMilligramsPerMillimeter(kilogrampermeter.MilligramsPerMillimeter).KilogramsPerMeter, MilligramsPerMillimeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromPoundsPerFoot(kilogrampermeter.PoundsPerFoot).KilogramsPerMeter, PoundsPerFootTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromPoundsPerInch(kilogrampermeter.PoundsPerInch).KilogramsPerMeter, PoundsPerInchTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LinearDensity v = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LinearDensity.FromKilogramsPerMeter(3)-v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LinearDensity.FromKilogramsPerMeter(10)/5).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, LinearDensity.FromKilogramsPerMeter(10)/LinearDensity.FromKilogramsPerMeter(5), KilogramsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LinearDensity oneKilogramPerMeter = LinearDensity.FromKilogramsPerMeter(1);
            LinearDensity twoKilogramsPerMeter = LinearDensity.FromKilogramsPerMeter(2);

            Assert.True(oneKilogramPerMeter < twoKilogramsPerMeter);
            Assert.True(oneKilogramPerMeter <= twoKilogramsPerMeter);
            Assert.True(twoKilogramsPerMeter > oneKilogramPerMeter);
            Assert.True(twoKilogramsPerMeter >= oneKilogramPerMeter);

            Assert.False(oneKilogramPerMeter > twoKilogramsPerMeter);
            Assert.False(oneKilogramPerMeter >= twoKilogramsPerMeter);
            Assert.False(twoKilogramsPerMeter < oneKilogramPerMeter);
            Assert.False(twoKilogramsPerMeter <= oneKilogramPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Equal(0, kilogrampermeter.CompareTo(kilogrampermeter));
            Assert.True(kilogrampermeter.CompareTo(LinearDensity.Zero) > 0);
            Assert.True(LinearDensity.Zero.CompareTo(kilogrampermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = LinearDensity.FromKilogramsPerMeter(1);
            var b = LinearDensity.FromKilogramsPerMeter(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = LinearDensity.FromKilogramsPerMeter(1);
            var b = LinearDensity.FromKilogramsPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = LinearDensity.FromKilogramsPerMeter(1);
            Assert.True(v.Equals(LinearDensity.FromKilogramsPerMeter(1), KilogramsPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LinearDensity.Zero, KilogramsPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.False(kilogrampermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.False(kilogrampermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LinearDensityUnit.Undefined, LinearDensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LinearDensityUnit)).Cast<LinearDensityUnit>();
            foreach(var unit in units)
            {
                if(unit == LinearDensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LinearDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 g/cm", new LinearDensity(1, LinearDensityUnit.GramPerCentimeter).ToString());
                Assert.Equal("1 g/m", new LinearDensity(1, LinearDensityUnit.GramPerMeter).ToString());
                Assert.Equal("1 g/mm", new LinearDensity(1, LinearDensityUnit.GramPerMillimeter).ToString());
                Assert.Equal("1 kg/cm", new LinearDensity(1, LinearDensityUnit.KilogramPerCentimeter).ToString());
                Assert.Equal("1 kg/m", new LinearDensity(1, LinearDensityUnit.KilogramPerMeter).ToString());
                Assert.Equal("1 kg/mm", new LinearDensity(1, LinearDensityUnit.KilogramPerMillimeter).ToString());
                Assert.Equal("1 µg/cm", new LinearDensity(1, LinearDensityUnit.MicrogramPerCentimeter).ToString());
                Assert.Equal("1 µg/m", new LinearDensity(1, LinearDensityUnit.MicrogramPerMeter).ToString());
                Assert.Equal("1 µg/mm", new LinearDensity(1, LinearDensityUnit.MicrogramPerMillimeter).ToString());
                Assert.Equal("1 mg/cm", new LinearDensity(1, LinearDensityUnit.MilligramPerCentimeter).ToString());
                Assert.Equal("1 mg/m", new LinearDensity(1, LinearDensityUnit.MilligramPerMeter).ToString());
                Assert.Equal("1 mg/mm", new LinearDensity(1, LinearDensityUnit.MilligramPerMillimeter).ToString());
                Assert.Equal("1 lb/ft", new LinearDensity(1, LinearDensityUnit.PoundPerFoot).ToString());
                Assert.Equal("1 lb/in", new LinearDensity(1, LinearDensityUnit.PoundPerInch).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 g/cm", new LinearDensity(1, LinearDensityUnit.GramPerCentimeter).ToString(swedishCulture));
            Assert.Equal("1 g/m", new LinearDensity(1, LinearDensityUnit.GramPerMeter).ToString(swedishCulture));
            Assert.Equal("1 g/mm", new LinearDensity(1, LinearDensityUnit.GramPerMillimeter).ToString(swedishCulture));
            Assert.Equal("1 kg/cm", new LinearDensity(1, LinearDensityUnit.KilogramPerCentimeter).ToString(swedishCulture));
            Assert.Equal("1 kg/m", new LinearDensity(1, LinearDensityUnit.KilogramPerMeter).ToString(swedishCulture));
            Assert.Equal("1 kg/mm", new LinearDensity(1, LinearDensityUnit.KilogramPerMillimeter).ToString(swedishCulture));
            Assert.Equal("1 µg/cm", new LinearDensity(1, LinearDensityUnit.MicrogramPerCentimeter).ToString(swedishCulture));
            Assert.Equal("1 µg/m", new LinearDensity(1, LinearDensityUnit.MicrogramPerMeter).ToString(swedishCulture));
            Assert.Equal("1 µg/mm", new LinearDensity(1, LinearDensityUnit.MicrogramPerMillimeter).ToString(swedishCulture));
            Assert.Equal("1 mg/cm", new LinearDensity(1, LinearDensityUnit.MilligramPerCentimeter).ToString(swedishCulture));
            Assert.Equal("1 mg/m", new LinearDensity(1, LinearDensityUnit.MilligramPerMeter).ToString(swedishCulture));
            Assert.Equal("1 mg/mm", new LinearDensity(1, LinearDensityUnit.MilligramPerMillimeter).ToString(swedishCulture));
            Assert.Equal("1 lb/ft", new LinearDensity(1, LinearDensityUnit.PoundPerFoot).ToString(swedishCulture));
            Assert.Equal("1 lb/in", new LinearDensity(1, LinearDensityUnit.PoundPerInch).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s1"));
                Assert.Equal("0.12 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s2"));
                Assert.Equal("0.123 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s3"));
                Assert.Equal("0.1235 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 kg/m", new LinearDensity(0.123456, LinearDensityUnit.KilogramPerMeter).ToString("s4", culture));
        }
    }
}
