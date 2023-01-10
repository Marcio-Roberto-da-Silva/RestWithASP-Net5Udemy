using RestWithASPNet5Udemy1.Hypermedia;
using RestWithASPNet5Udemy1.Hypermedia.Abstract;
using RestWithASPNet5Udemy1.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestWithASPNet5Udemy1.Data.VO {
    
    public class PersonVO : ISupportsHyperMedia {
        public long Id { get; set; }
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string Gender { get; set; }

        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

