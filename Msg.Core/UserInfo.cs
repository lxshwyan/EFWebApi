using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Msg.Core
{
    [Table("UserInfo")]
  public  class UserInfo: EntityBase
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserMail { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        public int MyProperty { get; set; }
    }

    [Table("UserInfo2")]
    public class UserInfo2 : EntityBase
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserMail { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        public int MyProperty { get; set; }
    }
}
