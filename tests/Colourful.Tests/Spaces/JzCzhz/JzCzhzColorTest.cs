﻿using Colourful.Tests.Assertions;
using Xunit;

namespace Colourful.Tests
{
    public class JzCzhzColorTest
    {
        [Fact]
        public void Equals_Same()
        {
            var first = new JzCzhzColor(jz: 0.6, cz: 0.3, hz: 150);
            var second = new JzCzhzColor(jz: 0.6, cz: 0.3, hz: 150);
            CustomAssert.EqualsWithHashCode(first, second);
        }

        [Fact]
        public void Equals_Different()
        {
            var first = new JzCzhzColor(jz: 0.7, cz: 0.3, hz: 150);
            var second = new JzCzhzColor(jz: 0.6, cz: 0.3, hz: 150);
            CustomAssert.NotEqualsWithHashCode(first, second);
        }

        [Fact]
        public void VectorCtor()
        {
            var first = new JzCzhzColor(jz: 0.6, cz: 0.3, hz: 150);
            var vector = new[] { 0.6, 0.3, 150 };
            var second = new JzCzhzColor(vector);
            CustomAssert.EqualsWithHashCode(first, second);
            Assert.Equal(vector, second.Vector);
        }

        [Fact]
        public void FromSaturationCtor()
        {
            var first = new JzCzhzColor(jz: 10, cz: 3, hz: 20);
            const double saturation = 30d;
            var second = JzCzhzColor.FromSaturation(lightness: 10, hue: 20, saturation);
            CustomAssert.EqualsWithHashCode(first, second);
            Assert.Equal(saturation, second.Saturation);
        }

        [Fact]
        public void ToString_Simple()
        {
            var color = new JzCzhzColor(jz: 0.6, cz: 0.3, hz: 150);
            Assert.Equal("JzCzhz [Jz=0.6, Cz=0.3, hz=150]", color.ToString());
        }
    }
}