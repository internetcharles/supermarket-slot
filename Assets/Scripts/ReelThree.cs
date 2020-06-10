using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelThree : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;


    // initiating hardcoded slot from unity system
    [SerializeField] public List<GameObject> SlotReelThree;

    public Transform[] reelThreeObjectList;


    void Update()
    {
        reelThreeObjectList = gameObject.GetComponentsInChildren<Transform>();
    }

    public void RefreshReels()
    {
            for (int i = 0; i < 13; i++)
        {
            Destroy(GetComponent<Transform>().GetChild(i).gameObject);
        }
    }

    //public void PlayAnim3()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelThree"].layer = 100;
    //    anim.Play("SlotSpinReelThree");
    //}

    //public void PlayNewAnim3()
    //{
    //    anim = gameObject.GetComponent<Animation>();
    //    anim["SlotSpinReelThreeSecond"].layer = 100;
    //    anim.Play("SlotSpinReelThreeSecond");
    //}

}
