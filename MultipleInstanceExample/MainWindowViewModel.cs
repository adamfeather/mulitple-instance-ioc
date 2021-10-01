using MultipleInstanceExample.Domain;
using System.Collections.Generic;

namespace MultipleInstanceExample
{
    public class MainWindowViewModel
    {
        private readonly IEnumerable<IThing> _things;

        public MainWindowViewModel(IEnumerable<IThing> things)
        {
            _things = things;
        }
    }
}
