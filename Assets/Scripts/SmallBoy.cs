using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBoy : MonoBehaviour
{

    [SerializeField] public int scoreValue = 50;

    public int ReturnScore()
    {
        return scoreValue;
    }


}