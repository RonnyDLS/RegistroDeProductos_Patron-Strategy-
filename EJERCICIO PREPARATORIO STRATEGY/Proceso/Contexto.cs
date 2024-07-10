using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;

namespace EJERCICIO_PREPARATORIO_STRATEGY.Proceso
{
    internal class Contexto
    {
        public IProceso _instacia;
        public Contexto(IProceso instancia)
        {
            _instacia = instancia;
        }

        public void ejecutarProcesoImpuesto()
        {
            _instacia.ejecutar();
        }

    }
}
