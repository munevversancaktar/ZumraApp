using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZumraApp.Data.Model.Models.Articles
{
    public class Article
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string  Description { get; set; }

        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int ArticleTypeID { get; set; }

        public int WriterID { get; set; }

        public int ImageID { get; set; }

        public int Like { get; set; }

        public int Seen { get; set; }

        public bool Activated { get; set; }

        public virtual List<Image> Images { get; set; }

        public virtual List<Category> Categories { get; set; }

        public virtual List<Writer> Writers { get; set; }


    }

  
}
