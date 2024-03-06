using BLLClassLibrary.Model.Documento;
using BLLClassLibrary.Model.Firma;



namespace UI01.ConsoleApp
{

    class Program
    {
        static void main(string[] args)
        {
            var correo = "direccion_de_correo@soy.sena.edu.co";
            var generadorFirma = new GeneradorFirma();
            var documento = new Documento(generadorFirma);
            documento.EscribirTitulo("Documento01_de_Prueba");
            documento.EscribirCuerpo("Cuerpo del Documento de preuba 01 ");
            //documento.EnviarPorCorreo(correo);
            using (var emailSender = new EmailSender())
            {
                emailSender.Enviar(correo, documento.GenerarDocumento());
            }

            Console.ReadKey();
        }
    }
}