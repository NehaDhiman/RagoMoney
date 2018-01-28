using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RagoMoney.Recharge.Dto
{
    //[AutoMapFrom(typeof(User))]
    public class RechargeDto : EntityDto<long>
    {
        [Required]
        //[StringLength(AbpUserBase.MaxUserNameLength)]
        public string MobileNumber { get; set; }

        [Required]
        //[StringLength(AbpUserBase.MaxNameLength)]
        public string Operator { get; set; }

        [Required]
        //[StringLength(AbpUserBase.MaxSurnameLength)]
        public string Circle { get; set; }

        [Required]
        //[StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Amount { get; set; }
    }
}
