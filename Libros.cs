namespace Segundo_Parcial
{
    public class Libros
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string AnioP {  get; set; }
        public Libros() 
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            AnioP = string.Empty;
        }
    }
}
