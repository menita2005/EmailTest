using Xunit;
using Moq;
using BLLClassLibrary.Model.Documento;
using BLLClassLibrary.Model.Firma;

namespace YourNamespace.Tests
{
    public class DocumentoTests
    {
        [Theory]
        [InlineData("Título 1", "Cuerpo 1", "Firma 1", "Título 1Cuerpo 1Firma 1")]
        [InlineData("Título 2", "Cuerpo 2", "Firma 2", "Título 2Cuerpo 2Firma 2")]
        [InlineData("", "", "", "")]
        public void GenerarDocumento_ReturnsCorrectDocument(string titulo, string cuerpo, string firma, string expected)
        {
            // Mock del generador de firma
            var mockFirma = new Mock<IGeneradorFirma>();
            mockFirma.Setup(f => f.Firma()).Returns(firma);

            // Act
            var documento = new Documento(mockFirma.Object);
            documento.EscribirTitulo(titulo);
            documento.EscribirCuerpo(cuerpo);
            string actual = documento.GenerarDocumento();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
