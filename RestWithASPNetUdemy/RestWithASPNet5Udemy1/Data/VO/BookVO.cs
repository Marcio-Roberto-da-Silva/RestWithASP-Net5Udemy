using RestWithASPNet5Udemy1.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using RestWithASPNet5Udemy1.Hypermedia;
using System.Collections.Generic;
using RestWithASPNet5Udemy1.Hypermedia.Abstract;

namespace RestWithASPNet5Udemy1.Data.VO {
    
    public class BookVO : ISupportsHyperMedia {
        public long Id { get; set; }
        public string Title { get; set; }
       
        public string Author { get; set; }
        
        public decimal Price { get; set; }
        
        public DateTime LaunchDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}

