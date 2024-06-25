using MediatR;

namespace FSH.WebApi.Catalog.Application.Products.Get.v1;
public class GetProductRequest : IRequest<GetProductResponse>
{
    public Guid Id { get; set; }
    public GetProductRequest(Guid id) => Id = id;
}