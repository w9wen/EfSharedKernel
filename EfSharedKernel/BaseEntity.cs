using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace w9wen.EfSharedKernel
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity
    {
        [DisplayName("序號")]
        public int Id { get; set; }

        [DisplayName("備註")]
        [DataType(DataType.MultilineText)]
        [StringLength(200)]
        public string Note { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Required]
        [DisplayName("建立時間")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [Editable(false)]
        [UIHint("DateTime")]
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// 建立者
        /// </summary>
        [Required]
        [DisplayName("建立者")]
        [Editable(false)]
        [StringLength(50)]
        public string CreatedUser { get; set; }

        /// <summary>
        /// 更新次數
        /// </summary>
        [Required]
        [DisplayName("更新次數")]
        [Editable(false)]
        public byte UpdatedTimes { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        [Required]
        [DisplayName("更新時間")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        [Editable(false)]
        [UIHint("DateTime")]
        public DateTime UpdatedDateTime { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [Required]
        [DisplayName("更新者")]
        [Editable(false)]
        [StringLength(50)]
        public string UpdatedUser { get; set; }

        /// <summary>
        /// 生效標記
        /// </summary>
        [Required]
        [DisplayName("生效標記")]
        [Editable(false)]
        public bool ValidFlag { get; set; }

        /// <summary>
        /// 資料版號
        /// </summary>
        [Required]
        [DisplayName("資料版號")]
        [Editable(false)]
        public byte[] Rowversion { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}