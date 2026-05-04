using System.ComponentModel.DataAnnotations;

namespace DeliveryApp.Api.Contracts.Requests;

public sealed record PaginationRequest(
    [property: Range(1, int.MaxValue)] int Page = 1,
    [property: Range(1, 50)] int PerPage = 10);
