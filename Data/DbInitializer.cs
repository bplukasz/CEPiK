using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CepikContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
