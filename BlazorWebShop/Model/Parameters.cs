namespace BlazorWebShop.Model
{
    public class Parameters
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 25;
        public int TotalCount { get; set; }
    }
}
