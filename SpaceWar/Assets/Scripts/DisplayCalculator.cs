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
    /// Ekranın sol kenarının kordinatlarını verir.
    /// </summary>
    public static float Left
    {
        get
        {
            return left;
        }
    }



    /// <summary>
    /// ekranın sağ tarafının kordinatlarını verir
    /// </summary>
    public static float Right
    {
        get { return right;}
    }


    /// <summary>
    /// Ekranın üst tarafının kordinatlarını verir.
    /// </summary>
    public static float Top
    {
        get { return top; }
    }




    /// <summary>
    /// ekranın alt tarafının kordinatlarını verir
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

        Vector3 solAltKoseOyunDunyası = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyası = Camera.main.ScreenToWorldPoint(sagUstKose);


        left = solAltKoseOyunDunyası.x;
        right = sagUstKoseOyunDunyası.x;
        top = sagUstKoseOyunDunyası.y;
        bottom = solAltKoseOyunDunyası.y;
       
    }



}
