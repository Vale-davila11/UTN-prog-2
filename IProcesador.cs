// ============================================================
// PATRÓN: Strategy
// INTERFAZ: Define el contrato que deben cumplir todas las
// estrategias de procesamiento de documentos.
// ============================================================

namespace ProcesadorDocumentos
{
    public interface IProcesador
    {
        void Procesar(string contenido);
    }
}
