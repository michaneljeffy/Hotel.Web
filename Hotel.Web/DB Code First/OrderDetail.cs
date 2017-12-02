using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Web.DB_Code_First
{
    [Table("OderDetail")]
    public class OrderDetail
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int OrderDetailId { get; set; }

        /// <summary>
        /// 订单价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 订单数量
        /// </summary>
        public int Account { get; set; }

        /// <summary>
        /// 外键，必须和表字段一致
        /// </summary>
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        /// <summary>
        /// 导航属性
        /// </summary>
        public virtual Order Order { get; set; }
    }
}