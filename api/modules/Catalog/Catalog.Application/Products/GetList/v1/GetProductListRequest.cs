using FSH.WebApi.Catalog.Application.Products.Get.v1;
using FSH.Framework.Core.Paging;
using MediatR;

namespace FSH.WebApi.Catalog.Application.Products.GetList.v1;

public record GetProductListRequest(PaginationFilter filter) : IRequest<PagedList<GetProductResponse>>;