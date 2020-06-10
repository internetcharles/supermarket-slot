using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;


    // initiating hardcoded slot from unity system
    [SerializeField] public List<GameObject> SlotReelTwo;


    void Start()
    {
    }

    //public void PlayAnim2()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelTwo"].layer = 100;
    //    anim.Play("SlotSpinReelTwo");
    //}

    //public void PlayNewAnim2()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelTwoSecond"].layer = 100;
    //    anim.Play("SlotSpinReelTwoSecond");
    //}

}
