namespace mis_clases
{
    public class AutoDTO
    {
        private string marca;
        private string idPropietario;
        private string patente;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string IdPropietario
        {
            get
            {
                return idPropietario;
            }

            set
            {
                idPropietario = value;
            }
        }

        public string Patente
        {
            get
            {
                return patente;
            }

            set
            {
                patente = value;
            }
        }
    }
}