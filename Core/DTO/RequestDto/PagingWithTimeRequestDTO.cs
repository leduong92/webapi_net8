using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO.BaseDto;


namespace Core.DTO.RequestDto
{
    public class PagingWithTimeRequestDTO : PagingBaseRequestDTO
    {
        public string Category { get; set; }
        public bool Reverse { get; set; }
        public string SortKey { get; set; }
    }
}
