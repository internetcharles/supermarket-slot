using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;


    // initiating hardcoded slot from unity system
    [SerializeField] public List<GameObject> SlotReelTwo;

    public Transform[] reelTwoObjectList;

    void Update()
    {
        reelTwoObjectList = gameObject.GetComponentsInChildren<Transform>();
    }

    public void RefreshReels()
    {
        for (int i = 0; i < 13; i++)
        {
            Destroy(GetComponent<Transform>().GetChild(i).gameObject);
        }
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
