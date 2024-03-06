using BLLClassLibrary.Model.Firma;
using Xunit;

namespace YourNamespace.Tests
{
    public class GeneradorFirmaTests
    {
        [Fact]
        public void Firma_ReturnsEmptyString()
        {
            // Arrange
            var generadorFirma = new GeneradorFirma();

            // Act
            string firma = generadorFirma.Firma();

            // Assert
            Assert.Equal(string.Empty, firma);
        }
    }
}

