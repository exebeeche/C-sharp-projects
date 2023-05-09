using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teapot_wpf.Model;

namespace Teapot_wpf.Presenter {
    public class Present {
        public Present(Teapot teapot) {
            Teapot = teapot;
        }

        private Teapot Teapot { get; set; }

        public void UpdateTPInfo() { }
    }
}
