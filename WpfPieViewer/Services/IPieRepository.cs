using System.Collections.Generic;
using WpfPieViewer.Models;

namespace WpfPieViewer.Services
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}