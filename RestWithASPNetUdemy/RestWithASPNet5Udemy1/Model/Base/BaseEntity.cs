using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestWithASPNet5Udemy1.Model.Base {
    public class BaseEntity {

        [Column("id")]
        public long Id { get; set; }
    }
}
