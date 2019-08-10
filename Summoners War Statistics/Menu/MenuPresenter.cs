﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class MenuPresenter
    {
        private readonly IMenuView view;
        private readonly Model model;

        public MenuPresenter(IMenuView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.MousePressed += View_MousePressed;
            this.view.MouseUnpressed += View_MouseUnpressed;
            this.view.MouseMoved += View_MouseMoved;
        }

        private void View_MouseMoved(Point location)
        {
            if (view.IsMouseDown)
            {
                if (view.MouseLocation.X < 0 && view.MouseLocation.Y < 0)
                {
                    view.MouseLocation = location;
                }
                else
                {
                    Point newMouseLocation = location;
                    for (int i = 0; i < view.ControlList.Count; i++)
                    {
                        Point newLocation = new Point(view.ControlList[i].Location.X + (newMouseLocation.X - view.MouseLocation.X), view.ControlList[i].Location.Y);
                        view.ControlList[i].Location = newLocation;
                    }
                }
            }
        }

        private void View_MouseUnpressed()
        {
            view.IsMouseDown = false;
            view.MouseLocation = new Point(-1, -1);
        }

        private void View_MousePressed()
        {
            view.IsMouseDown = true;
        }
    }
}
