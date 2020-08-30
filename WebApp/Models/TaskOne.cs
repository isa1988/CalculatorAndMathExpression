using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    /// <summary>
    /// Первое задание
    /// </summary>
    public class TaskOne : PageInfo
    {
        /// <summary>
        /// Математическое выражение
        /// </summary>
        [DisplayName("Математическое выражение")]
        public string Export { get; set; }

        /// <summary>
        /// Результат
        /// </summary>
        public string Result { get; set; }
    }
}