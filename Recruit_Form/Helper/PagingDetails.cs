﻿namespace Recruit_Form.Helper
{
    public class PagingDetails
    {

        public int TotalRows { get; set; }
        public int TotalPages { get; set; }
        public int CurPage { get; set; }
        public Boolean HasNextPage { get; set; }
        public Boolean HasPrevPage { get; set; }

        public String NextPageURL { get; set; }
        public String PrevPageURL { get; set; }
    }
}
