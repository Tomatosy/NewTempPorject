﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Security;

namespace Tomato.NewTempProject.WebApi
{
    /// <summary>
    /// 需要权限
    /// </summary>
    public class RequestAuthorizeAttribute : AuthorizeAttribute
    {
        string ErrorCode = "";
        string ErrorMessage = "";

        /// <summary>
        /// 需要权限
        /// </summary>
        public RequestAuthorizeAttribute()
        {
        }

        /// <summary>
        /// 验证权限
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            try
            {
                string controllerActionName = string.Join("/", actionContext.ActionDescriptor.ControllerDescriptor.ControllerName, actionContext.ActionDescriptor.ActionName);
                string userName = ApplicationContext.Current.UserName;
                Guid userId = ApplicationContext.Current.UserId;
                List<string> apiList = ApplicationContext.Current.ApiList;
                if (userName != null && userId != Guid.Empty && apiList != null)
                {
                    if (apiList.Contains(controllerActionName))
                    {
                        //权限通过
                        base.IsAuthorized(actionContext);
                    }
                    else
                    {
                        this.ErrorCode = EnumErrorCode.没有权限;
                        this.ErrorMessage = "没有权限进行此操作";
                        HandleUnauthorizedRequest(actionContext);
                    }

                }
                else
                {
                    //权限未通过
                    this.ErrorCode = EnumErrorCode.未登入;
                    this.ErrorMessage = "请重新登入";
                    HandleUnauthorizedRequest(actionContext);
                }

            }
            catch
            {
                //登入信息不存在
                this.ErrorCode = EnumErrorCode.未登入;
                this.ErrorMessage = "请重新登入";
                HandleUnauthorizedRequest(actionContext);
            }
        }

        /// <summary>
        /// 处理异常
        /// </summary>
        /// <param name="actionContext"></param>
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            base.HandleUnauthorizedRequest(actionContext);

            var response = actionContext.Response = actionContext.Response ?? new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.Forbidden;//Http 403
            var content = new ErrorResultModel<string>();
            content.Data = "Server denied access: you have no permission or be offline";
            content.ErrorCode = this.ErrorCode;
            content.ErrorMessage = this.ErrorMessage;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            response.Content = new StringContent(JsonConvert.SerializeObject(content, settings), Encoding.UTF8, "application/json");
        }
    }
}
