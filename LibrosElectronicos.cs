namespace Segundo_Parcial
{
    public class LibrosElectronicos:Libros
    {
        public string Formato {  get; set; }
        public string Tamanio {  get; set; }

        public LibrosElectronicos()
        { 
            Formato = string.Empty;
            Tamanio = string.Empty;
        }
    }
}
