using System;
using System.Data;
using System.Data.Objects;

namespace Infrastructure.Data
{
    public interface IUnitOfWork : IDisposable
    {
		/// <summary>
		/// Check wether transaction is running
		/// </summary>
		bool IsInTransaction { get; }

		/// <summary>
		/// Directly save change without using Begin & Commit Transaction
		/// </summary>
		void SaveChanges();

		/// <summary>
		/// Directly save change without using Begin & Commit Transaction with saving option
		/// </summary>
		void SaveChanges(SaveOptions saveOptions);

		/// <summary>
		/// Save change immediately than accept all change with Commit Transaction.
		/// </summary>
		void Save();

		/// <summary>
		/// Save change immediately than accept all change with Commit Transaction with saving option
		/// </summary>
		void Save(SaveOptions saveOptions);

		/// <summary>
		/// Start transaction
		/// </summary>
		void BeginTransaction();

		/// <summary>
		/// Start transaction with isolation level
		/// </summary>
		/// <param name="isolationLevel">isolation level</param>
		void BeginTransaction(IsolationLevel isolationLevel);

		/// <summary>
		/// Rollback transaction change
		/// </summary>
		void RollBackTransaction();

		/// <summary>
		/// Commit all transaction change
		/// </summary>
		void CommitTransaction();
	}
}
