namespace AdminSuppliers.Core
{
    [Serializable]
    public class Proveedor
	{
        public Proveedor(string cuit, string razonSocial, string descripcionEmpresa, string telefono)
        {
            Cuit = cuit;
            RazonSocial = razonSocial;
            Empresa = descripcionEmpresa;
            Telefono = telefono;
        }

        public Proveedor(string cuit, string razonSocial, string descripcionEmpresa, string telefono, double califiacion)
        {
            Cuit = cuit;
            RazonSocial = razonSocial;
            Empresa = descripcionEmpresa;
            Telefono = telefono;
            Califiacion = califiacion;
        }

        public Proveedor(int id, string cuit, string razonSocial, string descripcionEmpresa, string telefono, double califiacion)
        {
            this.id = id;
            Cuit = cuit;
            RazonSocial = razonSocial;
            Empresa = descripcionEmpresa;
            Telefono = telefono;
            Califiacion = califiacion;
            //Direccion = direccion;
        }

        public int id { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public double Califiacion{ get; set; }
        //public Direccion Direccion { get; set; }
    }
}
