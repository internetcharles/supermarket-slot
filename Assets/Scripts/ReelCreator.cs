using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

public class ReelCreator : MonoBehaviour
{

    [SerializeField] GameObject SmallBoy = default;
    [SerializeField] GameObject BigBoy = default;
    [SerializeField] private int ReelLength = default;

    public List<GameObject> reel1 = new List<GameObject>();
    public List<GameObject> reel2 = new List<GameObject>();
    public List<GameObject> reel3 = new List<GameObject>();


    private Vector3 reelOneTargetPosition = new Vector3(0, -15);
    private Vector3 reelTwoTargetPosition = new Vector3(0, -15);
    private Vector3 reelThreeTargetPosition = new Vector3(0, -15);

    private int totalScore = 0;
    public bool slotsSpun = false;
    public bool slotsSpinning = false;

    private Animation anim;

    // Start is called before the first frame update

    void Start()
    {


        anim = gameObject.GetComponent<Animation>();
        anim["SlotSpinReelOne"].layer = 100;
        anim["SlotSpinReelTwo"].layer = 100;
        anim["SlotSpinReelThree"].layer = 100;


        slotsSpun = true;
    }

    void Update()
    {
    }


    private void InstantiateIcons()
    {

        var newReelOne = GameObject.Find("Reel One").transform;
        var newReelTwo = GameObject.Find("Reel Two").transform;
        var newReelThree = GameObject.Find("Reel Three").transform;



        for (int i = 0; i < ReelLength - 1; i++)
        {
            {
                Vector3 slotPosition = new Vector3(-2, transform.position.y + i * 2,
                    transform.position.z);
                Instantiate(reel1[i], slotPosition, Quaternion.identity, newReelOne);
            }
        }

        for (int i = 0; i < ReelLength - 1; i++)
        {
            {
                Vector3 slotPosition = new Vector3(0, transform.position.y + i * 2,
                    transform.position.z);
                Instantiate(reel2[i], slotPosition, Quaternion.identity, newReelTwo);
            }

        }

        for (int i = 0; i < ReelLength - 1; i++)
        {
            {
                Vector3 slotPosition = new Vector3(2, transform.position.y + i * 2,
                    transform.position.z);
                Instantiate(reel3[i], slotPosition, Quaternion.identity, newReelThree);
            }

        }
        slotsSpun = true;
    }


    void SlotsPicker()
    {

        for (int i = 0; i < ReelLength; i++)
        {
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                reel1.Add(SmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                reel1.Add(BigBoy);
            }
        }

        for (int i = 0; i < ReelLength; i++)
        {
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                reel2.Add(SmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                reel2.Add(BigBoy);
            }
        }

        for (int i = 0; i < reel1.Count; i++)
        {
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                reel3.Add(SmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                reel3.Add(BigBoy);
            }
        }
    }

    void CheckResults()
    {
        var newReelOne = GameObject.Find("Reel One").transform;
        var newReelTwo = GameObject.Find("Reel Two").transform;
        var newReelThree = GameObject.Find("Reel Three").transform;
        int thirdToLastReel = ReelLength - 3;
        if (reel1[thirdToLastReel] == reel2[thirdToLastReel] && reel1[thirdToLastReel] == reel3[thirdToLastReel])
        {
            Debug.Log("You win!");
            if (reel1[thirdToLastReel] == BigBoy)
            {
                totalScore += 100;
            }
            else if (reel1[thirdToLastReel] == SmallBoy)
            {
                totalScore += 50;
            }
        }
        else
        {
            Debug.Log("You lose!");
        }
        Debug.Log(totalScore);
    }


    void TurnSlotsOff()
    {
        slotsSpun = false;
    }



}
