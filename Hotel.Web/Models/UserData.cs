using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Hotel.Web.Models
{
    /// <summary>
    /// 定义User模型，关联UserMetadata
    /// </summary>
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string RePwd { get; set; }
    }

    /// <summary>
    /// 定义与User相关联的属性
    /// </summary>
    public class UserMetadata
    {
        [DisplayName("用户名")]
        [Remote("NotExistUserName","Home")]
        public string UserName { get; set; }

        [DisplayName("备注")]
        [DataType (DataType.MultilineText)]
        public string Remark { get; set; }

        [DisplayName("年龄")]
        [Range(1,120)]
        public string Age { get; set; }
        
        [PasswordPropertyText]
        [DisplayName("密码")]
        public string Pwd { get; set; }

        [DisplayName("重输密码")]
        [System.ComponentModel.DataAnnotations.Compare("Pwd")]
        public string RePwd { get; set; }
        
        [DisplayName("邮箱")]
        [Email]
        public string Email { get; set; }
    }

    /// <summary>
    /// 自定义Email属性
    /// </summary>
    public class EmailAttribute:RegularExpressionAttribute
    {
        public EmailAttribute()
            :base(@"^w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        {

        }
    }
}