﻿namespace EntityFramework.BulkExtensions.BulkOperations
{
    internal static class OperationFactory
    {
        internal static IBulkOperation BulkInsert => new BulkInsert();

        internal static IBulkOperation BulkUpdate => new BulkUpdate();

        internal static IBulkOperation BulkDelete => new BulkDelete();
    }

    internal enum OperationType
    {
        Insert,
        Update,
        Delete
    }
}