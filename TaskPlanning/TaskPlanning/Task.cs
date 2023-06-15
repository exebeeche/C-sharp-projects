using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanning {
    public class Task {
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }

    }
}
