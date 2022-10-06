using Front_to_back.Models;
using System.Collections.Generic;

namespace Front_to_back.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Work> Works { get; set; }
        public SliderImage SliderImage { get; set; }
    }
}
