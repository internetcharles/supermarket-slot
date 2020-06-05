using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoy : MonoBehaviour
{

    [SerializeField] public int scoreValue = 100;

    public int ReturnScore()
    {
        return scoreValue;
    }

}
