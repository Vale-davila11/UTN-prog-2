namespace ProcesadorDocumentos
{
    // Estrategia concreta #1: encripta el documento
    public class ProcesadorEncriptado : IProcesador
    {
        public void Procesar(string contenido)
        {
            Console.WriteLine($"[Encriptado] Procesando: {contenido}");
        }
    }
}
