﻿using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.CodeGenerator.Infrastructure.Repositories.SQLite
{
    public class EnumItemRepository : SqlServer.EnumItemRepository
    {
        public EnumItemRepository(IDbContext context) : base(context)
        {
        }
    }
}
