using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Dto
{
    public class CarDetailDto :  IDto
    {
        public int ıd { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }
}
