﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// App场景
    /// </summary>
    public class AppInfo
    {
        /// <summary>
        /// 服务商应用APPID
        /// 1、服务商公众号APPID与商家公众号APPID，二选一必填。
        /// 2、可填写当前服务商商户号已绑定的公众号APPID。
        /// </summary>
        [JsonPropertyName("app_appid")]
        public string AppAppid { get; set; }
        /// <summary>
        /// 商家应用APPID
        /// 1、服务商公众号APPID与商家公众号APPID，二选一必填。
        /// 2、可填写与商家主体一致且已认证的公众号APPID，需是已认证的服务号、政府或媒体类型的订阅号。
        /// 3、审核通过后，系统将发起特约商家商户号与该AppID的绑定（即配置为sub_appid），服务商随后可在发起支付时选择传入该appid，以完成支付，并获取sub_openid用于数据统计，营销等业务场景 。
        /// 详细参见微信支付提供的省市对照表
        /// </summary>
        [JsonPropertyName("app_sub_appid")]
        public string AppSubAppid { get; set; }

        /// <summary>
        /// APP截图
        /// 1、请提供APP首页截图、尾页截图、应用内截图、支付页截图各1张。
        /// 2、请填写通过图片上传API预先上传图片生成好的MediaID。
        /// </summary>
        [JsonPropertyName("app_pics")]
        public List<string> AppPics { get; set; }
    }
}
