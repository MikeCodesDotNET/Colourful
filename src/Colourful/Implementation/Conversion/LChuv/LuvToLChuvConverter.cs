﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Colourful.Implementation.Conversion
{
    /// <summary>
    /// Converts from <see cref="LuvColor"/> to <see cref="LChuvColor"/>.
    /// </summary>
    public class LuvToLChuvConverter : IColorConversion<LuvColor, LChuvColor>
    {
        /// <summary>
        /// Converts from <see cref="LuvColor"/> to <see cref="LChuvColor"/>.
        /// </summary>
        public LChuvColor Convert(LuvColor input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            double L = input.L, u = input.u, v = input.v;
            var C = Math.Sqrt(u*u + v*v);
            var hRadians = Math.Atan2(v, u);
            var hDegrees = Angle.NormalizeDegree(Angle.RadianToDegree(hRadians));

            var output = new LChuvColor(L, C, hDegrees, input.WhitePoint);
            return output;
        }

        #region Overrides

        /// <inheritdoc cref="object" />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return true;
        }

        /// <inheritdoc cref="object" />
        public override int GetHashCode()
        {
            return 1;
        }

        /// <inheritdoc cref="object" />
        public static bool operator ==(LuvToLChuvConverter left, LuvToLChuvConverter right)
        {
            return Equals(left, right);
        }

        /// <inheritdoc cref="object" />
        public static bool operator !=(LuvToLChuvConverter left, LuvToLChuvConverter right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}