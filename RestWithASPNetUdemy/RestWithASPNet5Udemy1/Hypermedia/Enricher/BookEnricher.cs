using System;
using RestWithASPNet5Udemy1.Data.VO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using RestWithASPNet5Udemy1.Hypermedia.Constants;

namespace RestWithASPNet5Udemy1.Hypermedia.Enricher {
    public class BookEnricher : ContentResponseEnricher<BookVO> 
        {
        private readonly object _lock = new object();
        protected override void EnrichModel(BookVO content, IUrlHelper urlHelper) {

            var path = "api/person/v1";
            string link = GetLink(content.Id, urlHelper, path);

            content.Links.Add(new HyperMediaLink() {

                Action = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new HyperMediaLink() {
                Action = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new HyperMediaLink() {
                Action = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPut
            });
            content.Links.Add(new HyperMediaLink() {
                Action = HttpActionVerb.DELETE,
                Href = link,
                Rel = RelationType.self,
                Type = "int"
            });
            return;
        }
            private string GetLink(object id, IUrlHelper urlHelper, string path) {

            lock (_lock) 
                {
                var url = new { controller = path, id = id };
                return new StringBuilder(urlHelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            };
        }
    }
}
   
