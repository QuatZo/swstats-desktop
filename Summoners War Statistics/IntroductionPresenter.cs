using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class IntroductionPresenter
    {
        IIntroductionView view;
        Model model;

        public IntroductionPresenter(IIntroductionView view, Model model)
        {
            this.view = view;
            this.model = model;
        }

    }
}
