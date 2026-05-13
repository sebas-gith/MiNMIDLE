using System;
using System.Collections.Generic;
using System.Text;

namespace MiNMIDLE.Models
{
    public class Table
    {
        
        int Id { get; set; }
        public string Host { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public HttpMethod Method { get; set; }
        public string Query { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public string Extension { get; set;} = string.Empty;
        public int Length { get; set; } = 0;
        public int Time { get; set; } = 0;
        public DateTime Date { get; set;  } = DateTime.Now;
    }
}
