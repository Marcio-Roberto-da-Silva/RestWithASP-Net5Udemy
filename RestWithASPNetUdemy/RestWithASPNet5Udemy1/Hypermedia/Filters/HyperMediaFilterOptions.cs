using RestWithASPNet5Udemy1.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Hypermedia.Filters {
    public class HyperMediaFilterOptions 
        {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
