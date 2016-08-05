using System.Collections.Generic;

namespace DemoMigrations.Domain
{
    public class Empresa
    {
        public Empresa()
        {
            this.Clientes = new List<Cliente>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

    }
}
