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
                Assert.True(false);
            }
            catch(Exception exc)
            {
            }
        }

        [Fact]
        public void CircularBufferAddPass()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();
            test.arrayCreate(5);
            test.addOne(1);
            Assert.Equal(1, test.returnArraySpecific(0));
        }

        [Fact]
        public void CircularBufferAddFail()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();

            try {
                test.arrayCreate(0);
                test.addOne(1);
                Assert.True(false);
            } catch (Exception exc) {
            }
        }

        [Fact]
        public void CircularBufferOverwritePass()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();
            
            test.arrayCreate(1);
            test.addOne(1);
            test.addOne(2);

            Assert.Equal(2, test.returnArraySpecific(0));
        }

        [Fact]
        public void CircularBufferReadNextPass()
        {
            Circularbuffer<string> test = new Circularbuffer<string>();
            
            test.arrayCreate(3);
            test.addOne("something");
            test.addOne("else");
            test.addOne("another");

            test.forEachRead();

            Assert.True(true);
        }

        [Fact]
        public void CircularBufferReadNextFail()
        {
            Circularbuffer<string> test = new Circularbuffer<string>();
            
            test.arrayCreate(4);
            test.addOne("more");
            test.addOne("test");
            test.addOne("words");

            test.forEachRead();
        }

        [Fact]
        public void CircularBufferReadOldestPass()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();
            
            test.arrayCreate(3);
            test.addOne(1);
            test.addOne(2);
            test.addOne(3);
            test.addOne(4);

            Assert.Equal(2, test.oldestRead());
        }

        [Fact]
        public void CircularBufferReadOldestFail()
        {
            Circularbuffer<int> test = new Circularbuffer<int>();
            
            test.arrayCreate(1);

            Assert.Equal(0, test.oldestRead());
        }

        [Fact]
        public void CircularBufferReturnArraySpecificPass() {
            Circularbuffer<int> test = new Circularbuffer<int>();
            
            test.arrayCreate(1);
            test.addOne(1);

            Assert.Equal(1, test.returnArraySpecific(0));
        }
        
        [Fact]
        public void CircularBufferReturnArraySpecificFail() {
            Circularbuffer<int> test = new Circularbuffer<int>();
            
            test.arrayCreate(1);
            try {
                test.returnArraySpecific(20);
                Assert.True(false);
            } catch (IndexOutOfRangeException exc) {
            }
        }
    }
}
