﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelOne : MonoBehaviour
{
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelOne"].layer = 100;
        anim.Play("SlotSpinReelOne");
    }



}
