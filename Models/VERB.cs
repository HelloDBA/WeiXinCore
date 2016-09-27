using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeiXinCore.Models
{
    /// <summary>
    /// 用户微信接口配置信息表
    /// </summary>
    [Table("VERB")]
    public class VERB{
        /// <summary>
        /// 用户ID(GUID)
        /// </summary>
        [Key]
        [StringLength(32)]
        [Required]
        public string memberID{get;set;}
        /// <summary>
        /// 用户自定义Token
        /// </summary>
        [StringLength(32)]
        public string Token{get;set;}

        public DateTime? modDate { get; set; }
    }

}