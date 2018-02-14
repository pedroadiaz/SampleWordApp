using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SampleWordApp.ViewModel
{
    /// <summary>
    /// The view model for the custom flat model
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        private Window _window;
        private int _outerMargin = 10;
        private int _windowRadius = 10;

        public WindowViewModel(Window window)
        {
            _window = window;
        }

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }

        public int OuterMargin { get; set; }
    }
}
