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

        [Fact]
        public void CircularBufferCreateFail()
        {

        }

        [Fact]
        public void CircularBufferAddPass()
        {

        }

        [Fact]
        public void CircularBufferAddFail()
        {

        }

        [Fact]
        public void CircularBufferOverwritePass()
        {

        }

        [Fact]
        public void CircularBufferOverwriteFail()
        {

        }

        [Fact]
        public void CircularBufferReadNextPass()
        {

        }

        [Fact]
        public void CircularBufferReadNextFail()
        {

        }

        [Fact]
        public void CircularBufferReadOldestPass()
        {

        }

        [Fact]
        public void CircularBufferReadOldestFail()
        {

        }
    }
}
