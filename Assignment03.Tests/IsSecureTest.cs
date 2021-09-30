using System;
using Xunit;


namespace Assignment03.Tests{
    public class isSecureTest{
        
        [Theory]
        [InlineData("file://server/filename.ext")]
        [InlineData("ftp://www.facebook.com")]
        [InlineData("gopher://www.mywebsite.com")]
        public void isSecure_Returns_False_When_Not_Secured_by_htttps(String urlText){
            //Arrange
            var expected = false;
            var url = new Uri(urlText);
            
            //Act
            bool actual = url.isSecure();

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData("https://www.google.com")]
        [InlineData("https://facebook.com")]
        [InlineData("https://www.mywebsite.com")]
        public void isSecure_Returns_True_When_Secured_by_htttps(String urlText){
            //Arrange
            var expected = true;
            var url = new Uri(urlText);
            
            //Act
            bool actual = url.isSecure();

            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
