using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace w9wen.EfSharedKernel
{
    /// <summary>
    /// 地址
    /// </summary>
    [Keyless]
    public class Address
    {
        /// <summary>
        /// 取得或設定地址
        /// </summary>
        /// <value>地址</value>
        [Display(Name = "街/路")]
        [StringLength(100)]
        public string Street { get; private set; }

        /// <summary>
        /// 取得或設定城市
        /// </summary>
        /// <value>城市</value>
        [Display(Name = "城市")]
        [StringLength(30)]
        public string City { get; private set; }

        /// <summary>
        /// 取得或設定州/省/地區
        /// </summary>
        /// <value>州/省/地區</value>
        [Display(Name = "州/省/地區")]
        [StringLength(30)]
        public string State { get; private set; }

        /// <summary>
        /// 取得或設定郵遞區號
        /// </summary>
        /// <value>郵遞區號</value>
        [DataType(DataType.PostalCode)]
        [Display(Name = "郵遞區號")]
        [StringLength(10)]
        public string ZipCode { get; private set; }

        /// <summary>
        /// 取得或設定國別
        /// </summary>
        /// <value>國別</value>
        [Display(Name = "國別")]
        [StringLength(50)]
        public string Country { get; private set; }

        #region Constructor

        private Address()
        {
        }

        public Address(string street, string city, string state, string zipCode, string country)
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Country = country;
        }

        #endregion Constructor
    }
}