using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZumraApp.Data.Model.Models.Articles;

namespace ZumraApp.Data.Model.Models.Comments
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ArticleID { get; set; }

        public DateTime Date { get; set; }

        public bool Activated { get; set; }

        public virtual List<Article> Articles { get; set; }



    }
}
