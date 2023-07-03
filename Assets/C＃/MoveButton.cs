using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
    [SerializeField] Button ShopA;
    [SerializeField] Button ShopB;
    [SerializeField] Button MyStash;
    [SerializeField] Button Yakusou;
    [SerializeField] Button Dokukesi;
    [SerializeField] Button Seisui;
    [SerializeField] Button Exit;
    [SerializeField] Button Turugi;
    [SerializeField] Button Bougu;
    [SerializeField] Button Buy;
    [SerializeField] Button NotBuy;
    [SerializeField] Button Use;
    [SerializeField] Button NotUse;
    [SerializeField] Canvas SelectCanvas;
    [SerializeField] Canvas ShopACanvas;
    [SerializeField] Canvas ShopBCanvas;
    [SerializeField] Canvas BuyCanvas;
    [SerializeField] Canvas MyStashCanvas;
    [SerializeField] Canvas UseCanvas;
    

    private void Start()
    {
        //ÉÅÉ\ÉbÉhÇìoò^
        ShopA.onClick.AddListener(EnterShopA);
    }
    
    void EnterShopA()
    {
        //Ç±Ç±Ç…èàóù
        
    }
}
