using DAL.DataSetBarberShopTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassLogica
    {
        private TipoTratamientoTableAdapter _tipoTratamientos;
        private ClienteTableAdapter _clientes;
        private RegistroAplicacionTableAdapter _registroAplicacion;
        private PromocionTableAdapter _promociones;
        private RolEmpleadoTableAdapter _rolesEmpleados;
        private EmpleadoTableAdapter _empleados;
        private ProveedorTableAdapter _proveedores;
        private RegistroCompraTableAdapter _registroCompra;
        private ArticuloTableAdapter _articulos;
        private RetiroBodegaTableAdapter _retiroBodega;

        public ClassLogica()
        {
            _tipoTratamientos = new TipoTratamientoTableAdapter();
            _clientes = new ClienteTableAdapter();
            _registroAplicacion = new RegistroAplicacionTableAdapter();
            _promociones = new PromocionTableAdapter();
            _rolesEmpleados = new RolEmpleadoTableAdapter();
            _empleados = new EmpleadoTableAdapter();
            _proveedores = new ProveedorTableAdapter();
            _registroCompra = new RegistroCompraTableAdapter();
            _articulos = new ArticuloTableAdapter();
            _retiroBodega = new RetiroBodegaTableAdapter();
        }

        // Inicio seccion Add
        public void AddTipoTratamiento(string nombre, int duracion, float costo, byte[] imagen)
        {
            _tipoTratamientos.Insert(nombre, duracion, costo, imagen, 1);
        }

        public void AddCliente(string nombre, string apellido, int telefono)
        {
            _clientes.Insert(nombre, apellido, telefono, 1);
        }

        public void AddRegistroAplicacion(DateTime fechahora, int idtratamiento, int idcliente, string cui)
        {
            float costofinal = (float)_tipoTratamientos.ScalarQueryGetCosto(idtratamiento);
            float desc = (float)_promociones.ScalarQueryGetValidDiscount();
            costofinal = costofinal - ((costofinal * desc)/100);
            _registroAplicacion.Insert(fechahora, costofinal, 1, idtratamiento, idcliente, cui);
        }

        public void AddPromocion(string nombre, int porcentaje, string descripcion, DateTime f1, DateTime f2, int tratamiento)
        {
            _promociones.Insert(nombre, porcentaje, descripcion, f1, f2, 1, tratamiento);
        }

        public void AddRolEmpleado(string nombre, string descripcion)
        {
            _rolesEmpleados.Insert(nombre, descripcion, 1);
        }

        public void AddEmpleado(string cui, string nomb, string apell, string direcc, int tel, int rol)
        {
            _empleados.Insert(cui, nomb, apell, direcc, tel, 1, rol);
        }

        public void AddProveedor(string nomb, int tel)
        {
            _proveedores.Insert(nomb, tel, 1);
        }

        public void AddRegistroCompra(int unidades, float costofinal, int articulo, int proveedor)
        {
            _registroCompra.InsertQueryWithCurrentDateTime(unidades, costofinal, 1, articulo, proveedor);
        }

        public void AddArticulo(string nombre, string desc)
        {
            _articulos.Insert(nombre, desc, 1);
        }

        public void AddRetiroBodega(int cantidad, string cui, int articulo)
        {
            _retiroBodega.InsertQueryWithCurrentDateTime(cantidad, 1, cui, articulo);
        }
        // Fin seccion Add


        // Inicio seccion listar
        public DataTable ListarTiposTratamiento()
        {
            return _tipoTratamientos.GetDataByEnabled();
        }

        public DataTable ListarClientes()
        {
            return _clientes.GetDataByEnabled();
        }

        public DataTable ListarRegistroAplicacion()
        {
            return _registroAplicacion.GetDataByEnabled();
        }

        public DataTable ListarPromociones()
        {
            return _promociones.GetDataByEnabled();
        }

        public DataTable ListarRolesEmpleados()
        {
            return _rolesEmpleados.GetDataByEnabled();
        }

        public DataTable ListarEmpleados()
        {
            return _empleados.GetDataByEnabled();
        }

        public DataTable ListarProveedores()
        {
            return _proveedores.GetDataByEnabled();
        }

        public DataTable ListarRegistroCompra()
        {
            return _registroCompra.GetDataByEnabled();
        }

        public DataTable ListarArticulos()
        {
            return _articulos.GetDataByEnabled();
        }

        public DataTable ListarRetirosBodega()
        {
            return _retiroBodega.GetDataByEnabled();
        }
        // Fin seccion listar


        // Inicio seccion Eliminar
        public void EliminarTipoTratamiento(int id)
        {
            _tipoTratamientos.CustomDeleteQuery(id);
        }
        // Fin seccion Eliminar
    }
}