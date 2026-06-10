using ProcesadorDocumentos;

// Creamos un documento con estrategia de encriptado
Documento doc = new Documento("Informe anual 2025", new ProcesadorEncriptado());
doc.Procesar();

// Cambiamos la estrategia en tiempo de ejecución: ahora comprime
doc.SetProcesador(new ProcesadorComprimido());
doc.Procesar();
