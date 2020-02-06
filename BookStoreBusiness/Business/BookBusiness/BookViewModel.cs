using System;

namespace BookStoreBusiness
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public Nullable<bool> DelFlag { get; set; }
        public int Category { get; set; }

    }
}
