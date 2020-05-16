using System;
using Microsoft.AspNetCore.Mvc;

namespace notepad_api.Models
{
    public class Notepad
    {
        public DateTime CreatedOn { get; set; }
        public string Filename { get; set; }
        public string Text { get; set; }
    }
}