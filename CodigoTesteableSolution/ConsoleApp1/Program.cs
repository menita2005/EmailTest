using BLLCLassLibrary.Model.Documento;


namespace UI01.ConsoleApp
{

    class Program
    {
        static void main(string[] args)
        {
            var correo = "direccion_de_correo@soy.sena.edu.co";

            var documento = new Documento();
            documento.EscribirTitulo("Documento01_de_Prueba");
            documento.EscribirCuerpo("Cuerpo del Documento de preuba 01 ");
            documento.EnviarPorCorreo(correo);

            Console.ReadKey();
        }
    }
}

