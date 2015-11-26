﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScriptResourceRune : MonoBehaviour
{
    public Element element;
    public float maxCoolDown;
    public float CurCoolDown;
    Transform myTransform;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        maxCoolDown = 10;
        GetComponent<Image>().color = element.Color1;
    }

    void Update()
    {
        CoolDown();
    }

    public void CoolDown()
    {
        if (CurCoolDown > 0)
        {
            CurCoolDown -= Time.deltaTime;
            myTransform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
            myTransform.GetChild(0).GetComponent<Image>().fillAmount = CurCoolDown / maxCoolDown;
        }
        else
        {
            myTransform.GetChild(0).GetComponent<Image>().fillAmount = 1;
            myTransform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void StartCD()
    {
        CurCoolDown = maxCoolDown;
    }
}