using Vacation.model;
using Vacation.Model;

namespace Vacation.ViewModel
{
    public class AboutVM
    {
        public IEnumerable< City >City { get; set; }
        public IEnumerable<Deals> Deals { get; set; }
        public IEnumerable<Best > Best { get; set; }

    }
}
