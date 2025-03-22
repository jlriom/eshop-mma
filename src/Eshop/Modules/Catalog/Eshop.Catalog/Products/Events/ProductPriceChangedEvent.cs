namespace Eshop.Catalog.Products.Events;

public record ProductPriceChangedEvent(Product Product): IDomainEvent;
