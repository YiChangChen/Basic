using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Infrastructure.Entities
{
    public class SystemLog
    {
        [Key]
        public int Id { get; set; }
        public string AppName { get; set; }
        public string ExceptionLevel { get; set; }
        public string CorrelationId { get; set; }
        public string Controller { get; set; }
        public string UserId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public DateTime LogDT { get; set; }
    }
}
