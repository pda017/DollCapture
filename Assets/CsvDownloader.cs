using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class CsvDownloader
{
    public bool m_Success;
    public string m_Result;
    const string m_UrlFormat = "https://docs.google.com/spreadsheets/d/{0}/export?format=csv&gid={1}";
    public IEnumerator RequestSheetData(string docId, string gid)
    {
        m_Success = false;
        m_Result = string.Empty;
        var request = UnityWebRequest.Get(string.Format(m_UrlFormat, docId, gid));
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(string.Format("DocId:{0} gid:{1} Fail", docId, gid));
            yield break;
        }
        m_Success = true;
        m_Result = request.downloadHandler.text;
    }
    public void RequestSheetData(string docid, string gid,Action onComplete)
    {
        m_Success = false;
        m_Result = string.Empty;
        var request = UnityWebRequest.Get(string.Format(m_UrlFormat, docid, gid));
        request.SendWebRequest().completed += (asyncInfo)=>
        {
            if (request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(string.Format("DocId:{0} gid:{1} Fail", docid, gid));
            }
            m_Success = true;
            m_Result = request.downloadHandler.text;
            onComplete?.Invoke();
        };
    }
}
