using System;
using System.Collections.Generic;
using Xunit;

namespace CircularBuffer.Test
{
    public class CircularBufferTests
    {
        [Fact]
        public void CircularBufferCreatePass()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();


            test.arrayCreate(5);

            Assert.True(test.arrayGetSize() == 5);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircularBufferCreateFail(int Try)
        {
            Circularbuffer<int> test = new Circularbuffer<int>();

            try
            {
                test.arrayCreate(Try);
            }
            catch(Exception exc)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void CircularBufferAddPass()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferAddFail()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferOverwritePass()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferOverwriteFail()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferReadNextPass()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferReadNextFail()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferReadOldestPass()
        {
            Assert.False(true);
        }

        [Fact]
        public void CircularBufferReadOldestFail()
        {
            Assert.False(true);
        }
    }
}
