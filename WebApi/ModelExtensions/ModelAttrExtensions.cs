﻿using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Http.ModelBinding;
using System.Text;
using Tomato.StandardLib.MyExtensions;

namespace Tomato.NewTempProject.WebApi.Controllers
{
    public static class ModelAttrExtensions
    {
        public static string EditAttrVaild<T>(this T model, ModelStateDictionary ModelState) where T : class, new()
        {
            if (ModelState.IsValid)
            {
                return "";
            }
            StringBuilder resultStr = new StringBuilder();
            List<string> notNullColList = new List<string>();
            PropertyInfo[] PropertyList = model.GetType().GetProperties();
            foreach (PropertyInfo item in PropertyList)
            {
                if (!(item.GetValue(model, null) + "").IsNullOrEmpty())
                {
                    notNullColList.Add(item.Name);
                }
            }

            IEnumerator<ModelState> valueIEnumerator = ModelState.Values.GetEnumerator();

            foreach (string keyItem in ModelState.Keys)
            {
                valueIEnumerator.MoveNext();
                string colName = Regex.Split(keyItem, "model.", RegexOptions.IgnoreCase)[1];
                if (!notNullColList.Find(x => x == colName).IsNullOrEmpty())
                {
                    foreach (ModelError error in valueIEnumerator.Current.Errors)
                    {
                        resultStr.Append(error.ErrorMessage);
                    }
                }
            }
            return resultStr.ToString();
        }

        public static string AddAttrVaild<T>(ModelStateDictionary ModelState, T model) where T : class, new()
        {
            if (ModelState.IsValid)
            {
                return "";
            }
            StringBuilder resultStr = new StringBuilder();

            List<string> notNullColList = new List<string>();
            PropertyInfo[] PropertyList = model.GetType().GetProperties();
            foreach (PropertyInfo item in PropertyList)
            {
                if (!(item.GetValue(model, null) + "").IsNullOrEmpty())
                {
                    notNullColList.Add(item.Name);
                }
            }
            foreach (ModelState value in ModelState.Values)
            {
                foreach (ModelError error in value.Errors)
                {
                    resultStr.Append(error.ErrorMessage + ";");
                }
            }
            return resultStr.ToString();
        }
    }
}
