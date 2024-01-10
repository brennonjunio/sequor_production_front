using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequorTesteSelecao.Models
{
    public class OrderModel
    {
        public string Order { get; set; }
        public double Quantity { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public double CycleTime { get; set; }
        public List<MaterialModel> Materials { get; set; }
    }

    public class MaterialModel
    {
        public string MaterialCode { get; set; }
        public string MaterialDescription { get; set; }
    }

    public class ApiResponse
    {
        public int Status { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}
