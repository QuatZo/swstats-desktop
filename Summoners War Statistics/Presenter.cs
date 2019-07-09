using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class Presenter
    {
        private readonly IView view;
        private readonly Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.FormOnLoad += View_FormOnLoad;
        }

        private void View_FormOnLoad()
        {
            view.Test = model.Test();
        }
    }
}
