using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO.BaseDto;


namespace Core.DTO.RequestDto
{
    public class PagingWithTimeRequestDTO : PagingBaseRequestDTO
    {
        public string Category { get; set; }
        public string Sort { get; set; }
    }
}
