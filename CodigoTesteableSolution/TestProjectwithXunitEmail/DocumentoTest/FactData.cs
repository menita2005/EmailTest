using Xunit;
using Moq;
using BLLClassLibrary.Model.Firma;
using BLLClassLibrary.Model.Documento;

namespace TestProjectwithXunitEmail.DocumentoTest
{
    public class DocumentoTests
    {
        [Fact]
        public void GenerarDocumento_ReturnsCorrectDocument()
        {
            // Arrange
            string titulo = "Título del documento";
            string cuerpo = "Cuerpo del documento";
            string firma = "Firma del generador";
            string expected = titulo + cuerpo + firma;

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

        [Fact]
        public void GenerarDocumento_WithEmptyFields_ReturnsEmpty()
        {
            // Arrange
            string expected = "";

            // Mock del generador de firma
            var mockFirma = new Mock<IGeneradorFirma>();

            // Act
            var documento = new Documento(mockFirma.Object);
            string actual = documento.GenerarDocumento();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
