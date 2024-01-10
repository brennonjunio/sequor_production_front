using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequorTesteSelecao.Models
{
    public class OrderModel
    {
        public string order { get; set; }
        public double quantity { get; set; }  
        public string productCode { get; set; }
        public string productDescription { get; set; }
        public string image { get; set; }
        public double cycleTime { get; set; }  
        public Material[] materials { get; set; }
    }

    public class Material
    {
        public string materialCode { get; set; }
        public string materialDescription { get; set; }
    }


}
