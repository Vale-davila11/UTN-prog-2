namespace ProcesadorDocumentos
{
    // Estrategia concreta #2: comprime el documento
    public class ProcesadorComprimido : IProcesador
    {
        public void Procesar(string contenido)
        {
            Console.WriteLine($"[Comprimido] Procesando: {contenido}");
        }
    }
}
