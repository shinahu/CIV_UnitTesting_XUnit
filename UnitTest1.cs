using System;
using Xunit;
using CalcLib;

namespace tests
{
    public class UnitTest1
    {
      RecursiveCalc z = new RecursiveCalc();

        [Fact]
        public void Test1()
        {
            Assert.Equal(1,z.FactorialRec(0,1));
            Assert.Equal(24,z.FactorialRec(3,4));

        }
        [Theory]
        [InlineData(12, 3, 2)]
        [InlineData(24, 4, 1)]
        public void Test2(int expected, int input, int ans)
        {
        Assert.Equal(expected, z.FactorialRec(input, ans));
        }
        

        [Fact]
        public void Test1Fib()
         {
         Assert.Equal(true, z.FibCheck(5));
         }

        [Theory]
        [InlineData(true,2)]
        [InlineData(false,14)]
        public void Test3(Boolean expected,int num)
        {

          Assert.Equal(expected,z.FibCheck(num));
        }
        
        [Fact]
        public void Test1Prime()
         {
         Assert.Throws<DivideByZeroException>(() => z.PrimeCheckRec(3,0));
         }

         [Fact]
        public void Test2Prime()
        {
         Assert.Equal(true, z.PrimeCheckRec(5,2));
        }

         
        [Theory]
        [InlineData(false, 6, 2)]
        public void Test3Prime(Boolean expected, int num, int divisor) {
        Assert.Equal(expected, z.PrimeCheckRec(num, divisor));
        }

        [Fact]
         public void Test1Fibs()
         {
         Assert.Equal(2, z.FibonacciRec(0,1,1));
         }



        [Theory]
        [InlineData(34,2,4,2)]
        [InlineData(2019,45,6,4)]
        public void Test4(int expected,int num1, int num2, int numFibs)
        {
         Assert.Equal(expected,z.FibonacciRec(num1, num2, numFibs));
        }

    }
}
