using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Web.DB_Code_First
{
    [Table("Order")]
    public class Order
    {
        /// <summary>
        /// 主键，如果字段后含有Id,则会自动认为是主键
        /// </summary>
        [Key]
        public int OrderId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [StringLength(50)]
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderAmount { get; set; }

        /// <summary>
        /// 导航属性
        /// </summary>
        public virtual List<OrderDetail> OrderDetail { get; set; }
    }
}