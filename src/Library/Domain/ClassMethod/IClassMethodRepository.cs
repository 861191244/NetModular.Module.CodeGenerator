﻿using System;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.CodeGenerator.Domain.ClassMethod
{
    public interface IClassMethodRepository : IRepository<ClassMethodEntity>
    {
        /// <summary>
        /// 根据实体删除方法
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="uow"></param>
        /// <returns></returns>
        Task<bool> DeleteByClass(Guid classId, IUnitOfWork uow);

        /// <summary>
        /// 根据实体查询
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="uow"></param>
        /// <returns></returns>
        Task<ClassMethodEntity> GetByClass(Guid classId, IUnitOfWork uow = null);
    }
}
