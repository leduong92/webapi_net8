namespace Core.DTO.BaseDto
{
    public class PagingBaseRequestDTO
    {
        private const int MaxPageSize = 50;
        private int _pageSize = 20;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int PageIndex { get; set; } = 1;
        public string SearchKey { get; set; }
    }
}
