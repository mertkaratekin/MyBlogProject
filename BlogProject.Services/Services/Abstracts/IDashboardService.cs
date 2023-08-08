using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Services.Abstracts
{
    public interface IDashboardService
    {
        Task<List<int>> GetYearlyArticleCounts();
    }
}
