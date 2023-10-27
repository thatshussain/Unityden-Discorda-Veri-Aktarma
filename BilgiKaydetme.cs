using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System.Net;
using System.Text;

public class BilgiKaydetme : MonoBehaviour
{
   
    public TMP_InputField sicilno;
    public void BilgiKaydet(string bolum)
    {
        
        Debug.Log("Kullan�c�n�n Sicil Numaras�: " + sicilno.text);
        string huseyin = "";
        WebClient client = new WebClient();
        client.Headers.Add("Content-Type", "application/json");
        string payload = "{\"content\": \""+"**Sicil No:** " + "`"+sicilno.text+"`" + " " + "**Giri� Tarihi:** " + "`"+System.DateTime.Now.ToString()+"`" +  " " + "**Girdi�i B�l�m:** " + "`"+bolum+"`" + "\"}";
        client.UploadData(huseyin, Encoding.UTF8.GetBytes(payload));
        Debug.Log("Kullan�c�ya ait veriler kay�t ediliyor."); 
    }
}
