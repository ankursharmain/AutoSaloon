using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.EntityModel
{
    public partial class AutoSaloonDataEntities : DbContext
    {
        public AutoSaloonDataEntities(string connectionString) : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        partial void OnContextCreated();
    }
}
