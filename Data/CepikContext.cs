using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Data
{
    public class CepikContext : DbContext
    {
        public CepikContext(DbContextOptions<CepikContext> options) : base(options)
        {
        }
    }
}
