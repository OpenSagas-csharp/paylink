﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatelistQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherTemplatelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询结束时间。即查询create_start_time至此时间创建的模板，格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("create_end_time")]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 查询开始时间。即查询此时开始至 create_en_time 间创建的模板，格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("create_start_time")]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 页码，必须为大于0的整数， 1表示第一页，2表示第2页，依次类推。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，必须为大于0的整数，最大值为30
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}