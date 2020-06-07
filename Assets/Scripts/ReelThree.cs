using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelThree : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;


    // initiating hardcoded slot from unity system
    [SerializeField] public List<GameObject> SlotReelThree;

    void Start()
    {
        PlayAnim3();
    }

    public void PlayAnim3()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelThree"].layer = 100;
        anim.Play("SlotSpinReelThree");
    }

    public void PlayNewAnim3()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelThreeSecond"].layer = 100;
        anim.Play("SlotSpinReelThreeSecond");
    }

}
