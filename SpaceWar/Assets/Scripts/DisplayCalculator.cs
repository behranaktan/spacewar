using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DisplayCalculator
{
    static float left;
    static float right;
    static float top;
    static float bottom;






    /// <summary>
    /// Ekranýn sol kenarýnýn kordinatlarýný verir.
    /// </summary>
    public static float Left
    {
        get
        {
            return left;
        }
    }



    /// <summary>
    /// ekranýn sað tarafýnýn kordinatlarýný verir
    /// </summary>
    public static float Right
    {
        get { return right;}
    }


    /// <summary>
    /// Ekranýn üst tarafýnýn kordinatlarýný verir.
    /// </summary>
    public static float Top
    {
        get { return top; }
    }




    /// <summary>
    /// ekranýn alt tarafýnýn kordinatlarýný verir
    /// </summary>
    public static float Bottom
    {
        get { return bottom; }
    }

    public static void Init()
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni);

        Vector3 solAltKoseOyunDunyasý = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyasý = Camera.main.ScreenToWorldPoint(sagUstKose);


        left = solAltKoseOyunDunyasý.x;
        right = sagUstKoseOyunDunyasý.x;
        top = sagUstKoseOyunDunyasý.y;
        bottom = solAltKoseOyunDunyasý.y;
       
    }



}
