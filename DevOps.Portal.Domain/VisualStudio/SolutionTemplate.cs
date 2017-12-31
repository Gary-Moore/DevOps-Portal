using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Domain.VisualStudio
{
    public class SolutionTemplate : TableEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string RepositoryUrl { get; set; }

        public Uri Uri => new Uri(RepositoryUrl);
    }
}
