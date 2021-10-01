using MultipleInstanceExample.Domain;
using System.Collections.Generic;

namespace MultipleInstanceExample
{
    public class MainWindowViewModel
    {
        public IEnumerable<IThing> Things { get; }

        public MainWindowViewModel(IEnumerable<IThing> things)
        {
            Things = things;
        }
    }
}
