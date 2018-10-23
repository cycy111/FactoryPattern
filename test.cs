﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Net;
using System.IO;

public partial class _Default : System.Web.UI.Page
{

    /********************************************************************************************************/
    //数据发送
    /********************************************************************************************************/
    #region 数据发送
    protected void send()
    {
        string sendurl = "http://api.sms.cn/sms/";
        string mobile = "15900008888"; //发送号码
        string strContent = "您好，您的验证码是111【云信使】";
        StringBuilder sbTemp = new StringBuilder();
        string uid = "test";
        string pwd = "test123456";
        string Pass = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd + uid, "MD5"); //密码进行MD5加密
                                                                                                //POST 传值
        sbTemp.Append("ac=send&uid=" + uid + "&pwd=" + Pass + "&mobile=" + mobile + "&content=" + strContent);
        byte[] bTemp = System.Text.Encoding.GetEncoding("GBK").GetBytes(sbTemp.ToString());
        String postReturn = doPostRequest(sendurl, bTemp);
        Response.Write("Post response is: " + postReturn); //测试返回结果
    }
    //POST方式发送得结果
    private static String doPostRequest(string url, byte[] bData)
    {
        System.Net.HttpWebRequest hwRequest;
        System.Net.HttpWebResponse hwResponse;

        string strResult = string.Empty;
        try
        {
            hwRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            hwRequest.Timeout = 5000;
            hwRequest.Method = "POST";
            hwRequest.ContentType = "application/x-www-form-urlencoded";
            hwRequest.ContentLength = bData.Length;

            System.IO.Stream smWrite = hwRequest.GetRequestStream();
            smWrite.Write(bData, 0, bData.Length);
            smWrite.Close();
        }
        catch (System.Exception err)
        {
            WriteErrLog(err.ToString());
            return strResult;
        }

        //get response
        try
        {
            hwResponse = (HttpWebResponse)hwRequest.GetResponse();
            StreamReader srReader = new StreamReader(hwResponse.GetResponseStream(), Encoding.ASCII);
            strResult = srReader.ReadToEnd();
            srReader.Close();
            hwResponse.Close();
        }
        catch (System.Exception err)
        {
            WriteErrLog(err.ToString());
        }
        return strResult;
    }
    private static void WriteErrLog(string strErr)
    {
        Console.WriteLine(strErr);
        System.Diagnostics.Trace.WriteLine(strErr);
    }
    #endregion
}
