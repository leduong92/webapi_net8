namespace Core.DTO.BaseDto
{
    public class PagingBaseRequestDTO
    {
        private const int MaxPageSize = 50;
        private int _pageSize = 6;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int PageIndex { get; set; } = 1;
        public string Q { get; set; }
    }
}
