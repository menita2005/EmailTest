using BLLClassLibrary.Model.Email;
using BLLClassLibrary.Model.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary.Model.Documento
{
    public class Documento
    {
        private string _titulo;
        private string _cuerpo;
        private readonly IGeneradorFirma _generadorFirma;


        public Documento()
        {
            
        }
        public Documento(IGeneradorFirma generadorFirma)
        {
            this._generadorFirma = generadorFirma;
        }
        public void EscribirTitulo(string titulo)
        {
            this._titulo = titulo;
        }
        public void EscribirCuerpo(string cuerpo)
        {
            this._cuerpo = cuerpo;
        }
        public string GenerarDocumento()
        {
            return _titulo + _cuerpo + _generadorFirma.Firma();
        }
        
    }
}
