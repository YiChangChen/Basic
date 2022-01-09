using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Basic.Infrastructure.Entities
{
    public class CreateDatabaseCollationInterceptor : DbCommandInterceptor
    {
        private readonly string _collation;

        public CreateDatabaseCollationInterceptor(string collation)
        {
            _collation = collation;
        }

        public override InterceptionResult<int> NonQueryExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
        {
            var pattern = @"^CREATE DATABASE (\[.*\])(.*)$";
            if (Regex.IsMatch(command.CommandText, pattern))
            {
                command.CommandText = Regex.Replace(command.CommandText, pattern, $"CREATE DATABASE $1 COLLATE {_collation} $2");
            }

            return result;
        }

        public override ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            var pattern = @"^CREATE DATABASE (\[.*\])(.*)$";
            if (Regex.IsMatch(command.CommandText, pattern))
            {
                command.CommandText = Regex.Replace(command.CommandText, pattern, $"CREATE DATABASE $1 COLLATE {_collation} $2");
            }

            return new ValueTask<InterceptionResult<int>>(Task.FromResult(result));
        }
    }
}
