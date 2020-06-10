using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelOne : MonoBehaviour
{
    public Animation anim;

    public int randomInt = 5;

    // initiating hardcoded slot from unity system
    [SerializeField] public List<GameObject> SlotReelOne;


    // start method plays animation from SlotSpinReelOne
    void Start()
    {
    }

    //public void PlayAnim1()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelOne"].layer = 100;
    //    anim.Play("SlotSpinReelOne");
    //}

    //public void PlayNewAnim1()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelOneSecond"].layer = 100;
    //    anim.Play("SlotSpinReelOneSecond");
    //}

}
