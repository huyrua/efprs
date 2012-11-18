using System.Collections.Generic;
using Infrastructure.Model.Domain;

namespace Infrastructure.Tests.Data.Domain
{
    public class Category : Entity
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual IList<Product> Products { get; set; }
    }
}
