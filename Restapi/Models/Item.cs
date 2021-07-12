using System;

namespace Restapi.Models
{
    /* Using "Record" Types (pretty much a class)
        - Use for immutable objects : Instance of the object, it does not let it to be motified
        - "With" expressions support 
        - "Value - based" equality support : Not just the identity of the object, the both properties must
            be matched between two instances.
    */
    public record Item
    {
        public Guid Id { get; init; } // The "init" will not let this part to be motified
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}