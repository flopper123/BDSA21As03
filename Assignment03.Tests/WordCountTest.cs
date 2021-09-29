using System;
using Xunit;

namespace Assignment03.Tests{
    
    public class wordCountTest{
        [Theory]
        [InlineData("I am a happy boy", 5 )]
        [InlineData("I1am2a3happy4boy", 5 )]
        [InlineData("I, am 5. A happy_boy", 5)]
        public void wordCount_returns_the_corrct_wordcount(String line, int expected){
            //Arrange & Act
            int actual = line.wordCount();

            //Assert
            Assert.Equal(expected,actual);
        }
    }
}