using System.Collections;
using System.Collections.Generic;
using String = System.String;
using UnityEngine;
using TMPro;

public class LineNumMgr : MonoBehaviour
{
    public TMP_InputField editor;
    TMP_Text txt;
    string s;
    int el;
    int tl;

    void Start()
    {
        txt = GetComponent<TMP_Text>();
        txt.SetText(StringGen(1, 2));
    }


    void Update()
    {
        el = editor.text.Split("\n").Length;
        tl = txt.text.Split("\n").Length;
        if (tl <= el)
        {
            txt.SetText(StringGen(tl, el));
        }
    }


    string StringGen(int start, int end)
    {
        for (int i = start; i<= end; i++)
        {
            s += String.Format("{0,2}", i.ToString())+"\n";
        }

        return s;
    }
}
