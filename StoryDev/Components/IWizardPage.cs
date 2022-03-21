using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Components
{
    interface IWizardPage
    {

        bool CanGoForwards { get; }

    }
}
