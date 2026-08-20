using System.Collections.Generic;
using ESFE_Tienda.de_ropa.EN;
using ESFE_Tienda.de_ropa.DAL;

namespace ESFE_Tienda.de_ropa.LN
{
    // Facade estático que expone los métodos del DAL para la capa de lógica
    public static class ClientesLN
    {
        public static List<Clientes> ObtenerTodos() => ClientesDAL.ObtenerTodos();
        public static int Insertar(Clientes entidad) => ClientesDAL.Insertar(entidad);
        public static Clientes ObtenerPorId(int id) => ClientesDAL.ObtenerPorId(id);
    }

    public static class VentasLN
    {
        public static int Insertar(Ventas entidad) => VentasDAL.Insertar(entidad);
        public static List<Ventas> ObtenerTodos() => VentasDAL.ObtenerTodos();
        public static Ventas ObtenerPorCodigo(string codigo) => VentasDAL.ObtenerPorCodigo(codigo);
        public static int Actualizar(Ventas entidad) => VentasDAL.Actualizar(entidad);
        public static int Eliminar(string codigo) => VentasDAL.Eliminar(codigo);
    }

    public static class UsuarioLN
    {
        public static int Insertar(Usuario entidad) => UsuarioDAL.Insertar(entidad);
        public static List<Usuario> ObtenerTodos() => UsuarioDAL.ObtenerTodos();
        public static Usuario ObtenerPorId(int id) => UsuarioDAL.ObtenerPorId(id);
        public static int Actualizar(Usuario entidad) => UsuarioDAL.Actualizar(entidad);
        public static int Eliminar(int id) => UsuarioDAL.Eliminar(id);
    }

    public static class Tipo_ProductoLN
    {
        public static int Insertar(Tipo_Producto entidad) => Tipo_ProductoDAL.Insertar(entidad);
        public static List<Tipo_Producto> ObtenerTodos() => Tipo_ProductoDAL.ObtenerTodos();
        public static Tipo_Producto ObtenerPorId(int id) => Tipo_ProductoDAL.ObtenerPorId(id);
        public static int Actualizar(Tipo_Producto entidad) => Tipo_ProductoDAL.Actualizar(entidad);
        public static int Eliminar(int id) => Tipo_ProductoDAL.Eliminar(id);
    }

    public static class TelaLN
    {
        public static int Insertar(Tela entidad) => TelaDAL.Insertar(entidad);
        public static List<Tela> ObtenerTodos() => TelaDAL.ObtenerTodos();
        public static Tela ObtenerPorId(int id) => TelaDAL.ObtenerPorId(id);
        public static int Actualizar(Tela entidad) => TelaDAL.Actualizar(entidad);
        public static int Eliminar(int id) => TelaDAL.Eliminar(id);
    }

    public static class TallasLN
    {
        public static int Insertar(Tallas entidad) => TallasDAL.Insertar(entidad);
        public static List<Tallas> ObtenerTodos() => TallasDAL.ObtenerTodos();
        public static Tallas ObtenerPorId(int id) => TallasDAL.ObtenerPorId(id);
    }

    public static class RolesLN
    {
        public static int Insertar(Roles entidad) => RolesDAL.Insertar(entidad);
        public static List<Roles> ObtenerTodos() => RolesDAL.ObtenerTodos();
        public static Roles ObtenerPorId(int id) => RolesDAL.ObtenerPorId(id);
    }

    public static class PermisoLN
    {
        public static int Insertar(Permiso entidad) => PermisoDAL.Insertar(entidad);
        public static List<Permiso> ObtenerTodos() => PermisoDAL.ObtenerTodos();
        public static Permiso ObtenerPorId(int id) => PermisoDAL.ObtenerPorId(id);
    }

    public static class ColorLN
    {
        public static int Insertar(Color entidad) => ColorDAL.Insertar(entidad);
        public static List<Color> ObtenerTodos() => ColorDAL.ObtenerTodos();
        public static Color ObtenerPorId(int id) => ColorDAL.ObtenerPorId(id);
    }

    public static class ProductoLN
    {
        public static int Insertar(Productos entidad) => ProductoDAL.Insertar(entidad);
        public static List<Productos> ObtenerTodos() => ProductoDAL.ObtenerTodos();
        public static Productos ObtenerPorCodigo(string codigo) => ProductoDAL.ObtenerPorCodigo(codigo);
    }

    public static class BitacoraLN
    {
        public static int Insertar(Bitacora entidad) => BitacoraDAL.Insertar(entidad);
        public static List<Bitacora> ObtenerTodos() => BitacoraDAL.ObtenerTodos();
        public static List<Bitacora> ObtenerPorUsuario(int idUsuario) => BitacoraDAL.ObtenerPorUsuario(idUsuario);
    }
}
