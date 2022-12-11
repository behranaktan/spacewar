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
    /// Ekran�n sol kenar�n�n kordinatlar�n� verir.
    /// </summary>
    public static float Left
    {
        get
        {
            return left;
        }
    }



    /// <summary>
    /// ekran�n sa� taraf�n�n kordinatlar�n� verir
    /// </summary>
    public static float Right
    {
        get { return right;}
    }


    /// <summary>
    /// Ekran�n �st taraf�n�n kordinatlar�n� verir.
    /// </summary>
    public static float Top
    {
        get { return top; }
    }




    /// <summary>
    /// ekran�n alt taraf�n�n kordinatlar�n� verir
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

        Vector3 solAltKoseOyunDunyas� = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyas� = Camera.main.ScreenToWorldPoint(sagUstKose);


        left = solAltKoseOyunDunyas�.x;
        right = sagUstKoseOyunDunyas�.x;
        top = sagUstKoseOyunDunyas�.y;
        bottom = solAltKoseOyunDunyas�.y;
       
    }



}
