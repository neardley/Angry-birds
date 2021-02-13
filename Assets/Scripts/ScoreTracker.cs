using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreTracker 
{
    // Start is called before the first frame update
    private static int numShotLeft = 10;
    private static int lvl = 0;

    public static string ScoreToScreen()
    {
        return numShotLeft.ToString();
    }
    public static int ScoretoData()
    {
        return numShotLeft;
    }
    public static bool AmmoCheck()
    {
        if(numShotLeft > 0)
        {
            --numShotLeft;
            return true;
        }
        else
        {
            
            return false;
        }
    }

    public static int WhatLvl()
    {
        return lvl;
    }
    public static void Changelvl()
    {
        lvl += 1;
    }
}
