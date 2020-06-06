using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelTwo"].layer = 100;
        anim.Play("SlotSpinReelTwo");
    }
}
