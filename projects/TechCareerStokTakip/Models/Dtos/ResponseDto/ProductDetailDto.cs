using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto;

public record ProductDetailDto()
{
    public Guid Id { get; init; } //immutable olduğunu belirtmek için init yazdık.
    public string Name { get; init; }
    public int Stock { get; init; }
    public decimal Price { get; init; }
    public string CategoryName { get; init; }
}
