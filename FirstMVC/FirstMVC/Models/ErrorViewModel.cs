using System;

namespace FirstMVC.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}