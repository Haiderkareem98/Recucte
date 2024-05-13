using Recruit_Form.Form;

namespace Recruit_Form.Helper
{
    public class PagedResponse<T>
    {

        public string? Message { get; set; }

      //  public object? Data { get; set; }

        //public bool Error { get; set; }
        //        public PagedResponse(IQueryable<T> Query, PagingForm ClientPaging)
        //        {
        //            Paging = new PagingDetails();

        //            Paging.TotalRows = Query.Count();

        //            Paging.TotalPages = (int)Math.Ceiling((double)Paging.TotalRows / ClientPaging.PageSize);
        //            Paging.CurPage = ClientPaging.PageNumber;
        //            Paging.HasNextPage = Paging.CurPage < Paging.TotalPages;
        //            Paging.HasPrevPage = Paging.CurPage > 1;

        //            Data = Query.Skip((ClientPaging.PageNumber - 1) *
        //                            ClientPaging.PageSize).Take(ClientPaging.PageSize).ToList();
        //        }
        //        public PagingDetails Paging { get; set; }
        //        public List<T> Data { get; set; }    }
    }
}

