﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDSTecnologia.Site.Core.Entities;

namespace TDSTecnologia.Site.Infrastructure.Data
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> opcoes) : base(opcoes)
        {
        }

        public DbSet<Curso> CursoDao { get; set; }
    }
}
