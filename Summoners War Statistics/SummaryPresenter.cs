using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class SummaryPresenter
    {
        ISummaryView view;
        Model model;

        public SummaryPresenter(ISummaryView view, Model model)
        {
            this.view = view;
            this.model = model;
        }

    }
}
