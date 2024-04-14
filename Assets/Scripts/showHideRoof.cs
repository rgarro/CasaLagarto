using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 * Bonpo Nuns from Calgary ,sky gazing cabrinha
 * tengri all mighty  
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class showHideRoof : MonoBehaviour
{

    public GameObject roofMetalSheetA;
    public GameObject roofMetalSheetB;
    public GameObject roofMetalSheetC;
    public GameObject roofMetalSheetD;
public GameObject roofMetalSheetE;
    public GameObject roofMetalSheetF;
    public GameObject roofMetalSheetG;
    public GameObject roofMetalSheetH;

    private Boolean roof_is_shown = true;

    public Texture2D RoofIcon;
    public float IconX = 10;
    public float IconY = 10;
    public float IconWidth = 128;
    public float IconHeight = 128;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.RoofIcon)) 
        {
           if(this.roof_is_shown){
               this.roof_is_shown = false;
               this.hideRoof();
           }else{
               this.roof_is_shown = true;
               this.showRoof();
           }
        }
    }


    void showRoof(){
        this.roofMetalSheetA.SetActive(true);
        this.roofMetalSheetB.SetActive(true);
        this.roofMetalSheetC.SetActive(true);
        this.roofMetalSheetD.SetActive(true);
    }

     void hideRoof(){
        this.roofMetalSheetA.SetActive(false);
        this.roofMetalSheetB.SetActive(false);
        this.roofMetalSheetC.SetActive(false);
        this.roofMetalSheetD.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
