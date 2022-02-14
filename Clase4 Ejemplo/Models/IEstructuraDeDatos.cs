namespace Clase4_Ejemplo.Models
{
    public interface IEstructuraDeDatos<T>
    {
        void Insertar(T valor);
        void Actualizar(int pos);
        void Eliminar(int pos);
        T Obtener(int pos);
    }
}
