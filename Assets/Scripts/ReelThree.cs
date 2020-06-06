using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelThree : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelThree"].layer = 100;
        anim.Play("SlotSpinReelThree");
    }
}
