using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop.Data;

namespace workshop.Mapping
{
    public static class Mapping 
    {
        public static CreateIndexDescriptor ProductMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<Product>(m => m.Properties(p => p
                //.Keyword(k => k.Name(n => n.Id))
                .Text(t => t.Name(n => n.Name))
                .Text(t => t.Name(n => n.Category))
                .Number(t => t.Name(n => n.Code))
                .Number(t => t.Name(n => n.Price))
            )
            );
        }
    }
}
