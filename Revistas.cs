namespace Segundo_Parcial
{
    public class Revistas:Libros
    {
        public string Volumen {  get; set; }
        public string N_Ejemplar {  get; set; }

        public Revistas() 
        {
            Volumen = string.Empty;
            N_Ejemplar = string.Empty;  
        }

    }
}
