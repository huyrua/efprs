
namespace Infrastructure.Tests.Data.Domain.Mapping
{
    public class OrderLineMapping : EntityMappingBase<OrderLine>
    {
        public OrderLineMapping()
        {                        
            HasKey(x => x.Id);

            Property(x => x.Price);
            Property(x => x.Quantity);
            Property(x => x.ProductId);
            Property(x => x.OrderId);

            HasRequired(x => x.Order)
                .WithMany(o => o.OrderLines)
                .HasForeignKey(ol => ol.OrderId);

            HasRequired(x => x.Product)
                .WithMany(p => p.OrderLines)
                .HasForeignKey(ol => ol.ProductId);

            ToTable("OrderLine");
        }
    }
}
