using System.Collections.Generic;

namespace EFWP1.Models
{
    public class HomeModel
    {
        public IList<Category> Categories { get; set; } = new List<Category>();
        public IList<Product> Products { get; set; } = new List<Product>();

        public PageInfo CategoryPageInfo { get; set; } = new PageInfo();
        public PageInfo ProductPageInfo { get; set; } = new PageInfo();
    }
}   