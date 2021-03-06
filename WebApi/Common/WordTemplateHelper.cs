﻿using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;

public class WordTemplateHelper
{
    /// <summary>
    /// NPOI操作word
    /// </summary>
    /// <param name="TemplatePath">模板路径</param>
    /// <param name="SavePath">保存路径</param>
    /// <param name="keywords">关键字集合</param>
    public static void WriteToPublicationOfResult(string TemplatePath, string SavePath, Dictionary<string, string> keywords)
    {
        FileStream fs = new FileStream(TemplatePath, FileMode.Open, FileAccess.Read);
        XWPFDocument document = new XWPFDocument(fs);
        foreach (XWPFTable table in document.Tables)
        {
            foreach (XWPFTableRow row in table.Rows)
            {
                foreach (XWPFTableCell cell in row.GetTableCells())
                {
                    ReplaceKeyWords(cell.Paragraphs, keywords);//替换表格中的关键字
                }
            }
        }
        ReplaceKeyWords(document.Paragraphs, keywords);//替换模板中非表格的关键字
        FileStream output = new FileStream(SavePath, FileMode.Create);
        document.Write(output);
        fs.Close();
        fs.Dispose();
        output.Close();
        output.Dispose();
    }
    /// <summary>
    /// 遍历段落，替换关键字
    /// </summary>
    /// <param name="Paragraphs">段落</param>
    /// <param name="keywords">关键字集合</param>
    public static void ReplaceKeyWords(IList<XWPFParagraph> Paragraphs, Dictionary<string, string> keywords)
    {
        try
        {

            foreach (KeyValuePair<string, string> item in keywords)
            {
                foreach (XWPFParagraph para in Paragraphs)
                {
                    string oldtext = para.ParagraphText;
                    if (oldtext == "") continue;
                    string temptext = para.ParagraphText;
                    //if (temptext.Contains("{$" + item.Key + "}"))
                    //    temptext = temptext.Replace("{$" + item.Key + "}", item.Value);
                    if (temptext.Contains(item.Key))
                    {
                        temptext = temptext.Replace(item.Key, item.Value);

                        if (item.Value.IndexOf("\r\n") <= 0)
                        {
                            para.ReplaceText(oldtext, temptext);
                            continue;
                        }

                        XWPFRun r1 = para.CreateRun();
                        string[] myAgent = item.Value.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        for (int i = 0; i <= myAgent.Length - 1; i++)
                        {
                            r1.AppendText(myAgent[i]);
                            r1.FontSize = 14;
                            r1.AddCarriageReturn(); //插入换行符
                        }
                        para.ReplaceText(item.Key, "");
                    }
                }
            }
        }
        catch (System.Exception ex)
        {

            throw;
        }

    }
    /// <summary>
    /// 格式化关键字集合
    /// </summary>
    /// <typeparam name="T">泛型对象</typeparam>
    /// <param name="t">关键字集对象</param>
    /// <returns></returns>
    public static Dictionary<string, string> getProperties<T>(T t)
    {
        Dictionary<string, string> keywords = new Dictionary<string, string>();
        if (t == null)
        {
            return keywords;
        }
        System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

        if (properties.Length <= 0)
        {
            return keywords;
        }
        foreach (System.Reflection.PropertyInfo item in properties)
        {
            string name = item.Name;
            object value = item.GetValue(t, null);
            if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
            {
                keywords.Add(name, value.ToString());
            }
            else
            {
                getProperties(value);
            }
        }
        return keywords;
    }


}
