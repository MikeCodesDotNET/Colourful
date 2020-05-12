﻿using System;
using Colourful.Companding;

namespace Colourful.Strategy
{
    /// <summary>
    /// Keys for values in <see cref="IConversionMetadata"/>.
    /// </summary>
    public static class ConversionMetadataKeys
    {
        /// <summary>
        /// Type of the color converted. The value is a <see cref="System.Type"/>.
        /// </summary>
        public const string ColorType = nameof(ColorType);

        /// <summary>
        /// White point of the color converted. The value is a <see cref="Nullable{XYZColor}"/>.
        /// </summary>
        public const string WhitePoint = nameof(WhitePoint);
        
        /// <summary>
        /// RGB primaries of the color converted. The value is a <see cref="Nullable{RGBPrimaries}"/>.
        /// </summary>
        public const string RGBPrimaries = nameof(RGBPrimaries);
        
        /// <summary>
        /// Companding function of the color converted. The value is a <see cref="ICompanding"/>.
        /// </summary>
        public const string Companding = nameof(Companding);
    }
}