namespace ProcesadorDocumentos
{
    // Clase contexto: usa una estrategia de procesamiento.
    // No sabe NI LE IMPORTA cuál estrategia tiene asignada,
    // solo la ejecuta cuando se llama a Procesar().
    public class Documento
    {
        private string _contenido;
        private IProcesador _procesador;

        public Documento(string contenido, IProcesador procesador)
        {
            _contenido = contenido;
            _procesador = procesador;
        }

        // Permite cambiar la estrategia en tiempo de ejecución
        public void SetProcesador(IProcesador procesador)
        {
            _procesador = procesador;
        }

        public void Procesar()
        {
            _procesador.Procesar(_contenido);
        }
    }
}
