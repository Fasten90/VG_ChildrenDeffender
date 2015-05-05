using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm.Model
{
    class Moviecs
    {
        // ChildrenDeffenderWebAPI::Model::DBContext\Movie -ból átkopizva
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public Nullable<int> IndexImageID { get; set; }
        public string MovieLink { get; set; }
        public string LinkType { get; set; }
        public Nullable<int> SoundID { get; set; }
        public string Language { get; set; }
        public string NameEnglish { get; set; }
        public Nullable<int> FavID { get; set; }
        public Nullable<int> NextID { get; set; }
        public Nullable<bool> IsContinueable { get; set; }
        public Nullable<bool> IsFirst { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Category { get; set; }
        public short MinAge { get; set; }
        public int ManyViews { get; set; }
        public Nullable<System.DateTime> DateLastView { get; set; }
        public System.DateTime DateAdded { get; set; }


    }
}
