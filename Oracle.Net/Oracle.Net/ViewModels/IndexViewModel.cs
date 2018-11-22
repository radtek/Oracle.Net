using Oracle.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.ViewModels
{
    public class IndexViewModel
    {
        public List<News> News { get; set; }

        public List<Testlist> Testlist { get; set; }

        public List<Upload> Upload { get; set; }

        public IndexViewModel(List<News> news, List<Testlist> testlist, List<Upload> upload)
        {
            News = news;
            Testlist = testlist;
            Upload = upload;
        }
    }
}
