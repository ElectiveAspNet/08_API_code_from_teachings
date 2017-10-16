using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Model.Entities
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
    }
}
