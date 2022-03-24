using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Msg.Core
{
    public interface IRepository<T> where T : EntityBase
    {
        /// <summary>
        /// 通过自增长主键获取唯一Model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id);
        /// <summary>
        /// 通过自增长主键获取唯一Model(包含字段)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> criteria);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);

        IEnumerable<T> ListAll();
        Task<List<T>> ListAllAsync();

        IEnumerable<T> List(Expression<Func<T, bool>> criteria);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> criteria);
        IEnumerable<T> List(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);

        T Add(T entity, bool IsCommit = false);
        void Update(T entity);
        void Delete(T entity, bool IsCommit = false);
        void DeleteWhere(Expression<Func<T, bool>> criteria, bool IsCommit = false);
        void AddRange(IEnumerable<T> entities, bool IsCommit = false);
        void DeleteRange(IEnumerable<T> entities, bool IsCommit = false);
        void Attach(T entity);
        void AttachRange(IEnumerable<T> entities);
        void Detach(T entity);
        void DetachRange(IEnumerable<T> entities);
        void AttachAsModified(T entity);
        bool Commit();
        bool Commit(bool acceptAllChangesOnSuccess);
        Task<bool> CommitAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
