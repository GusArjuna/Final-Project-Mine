using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TrisatyaPopup;
    public GameObject DasadharmaPopup;
    public GameObject InfoPopup;
    public GameObject AboutPopup;

    public void TrisatyaOn()
    {
        TrisatyaPopup.SetActive(true);
    }

    public void TrisatyaOff()
    {
        TrisatyaPopup.SetActive(false);
    }
    public void DasadharmaOn()
    {
        DasadharmaPopup.SetActive(true);
    }

    public void DasadharmaOff()
    {
        DasadharmaPopup.SetActive(false);
    }
    public void InfoPopupOn()
    {
        InfoPopup.SetActive(true);
    }

    public void InfoPopupOff()
    {
        InfoPopup.SetActive(false);
    }
    public void AboutPopupOn()
    {
        AboutPopup.SetActive(true);
    }

    public void AboutPopupOff()
    {
        AboutPopup.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
