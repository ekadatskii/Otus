using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void IsEqual(float playerHp, float enemyHp)
    {
        if (playerHp == enemyHp)
        {
            
        }

        float epsilon = 0.0001f;
        float epsilobByMathf = Mathf.Epsilon;
        if (Mathf.Abs(playerHp - enemyHp) < epsilobByMathf)
        {
            
        }

        if (Mathf.Approximately(playerHp, enemyHp))
        {
            
        }
    }

    private int GetMaxOrMin(int a, int b, int c, int i, bool isMax)
    {
        return isMax ? Mathf.Max(a, b, c, i) : Mathf.Min(a, b, c, i);
    }

}
