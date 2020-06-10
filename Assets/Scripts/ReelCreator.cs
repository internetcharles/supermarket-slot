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
    [SerializeField] private int reelHeight = default;

    public ReelOne r1;
    public ReelTwo r2;
    public ReelThree r3;


    private int totalScore = 0;
    public bool slotsSpun = false;
    public bool slotsSpinning = false;

    private Animation anim;


    // Start is called before the first frame update

    void Start()
    {
        slotsSpun = true;

    }

    void Awake()
    {

    }

    void Update()
    {
    }


   // generates probability from random number
    public void SlotsPicker()
    {

        slotsSpun = true;

        var newReelOne = GameObject.Find("Reel One").transform;
        var newReelTwo = GameObject.Find("Reel Two").transform;
        var newReelThree = GameObject.Find("Reel Three").transform;

        r1.SlotReelOne.RemoveRange(0, 13);
        r2.SlotReelTwo.RemoveRange(0, 13);
        r3.SlotReelThree.RemoveRange(0, 13);

        r1.RefreshReels();
        r2.RefreshReels();
        r3.RefreshReels();

        for (int i = 0; i < ReelLength; i++)
        {
            
            Vector3 slotPosition = new Vector3(-2, transform.position.y + reelHeight + i * 2,
                transform.position.z);
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                GameObject newSmallBoy = Instantiate(SmallBoy, slotPosition, Quaternion.identity, newReelOne);
                r1.SlotReelOne.Add(newSmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                GameObject newBigBoy = Instantiate(BigBoy, slotPosition, Quaternion.identity, newReelOne);
                r1.SlotReelOne.Add(newBigBoy);
            }
        }

        for (int i = 0; i < ReelLength; i++)
        {
            Vector3 slotPosition = new Vector3(0, transform.position.y + reelHeight + i * 2,
                transform.position.z);
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                GameObject newSmallBoy = Instantiate(SmallBoy, slotPosition, Quaternion.identity, newReelTwo);
                r2.SlotReelTwo.Add(newSmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                GameObject newBigBoy = Instantiate(BigBoy, slotPosition, Quaternion.identity, newReelTwo);
                r2.SlotReelTwo.Add(newBigBoy);
            }
        }

        for (int i = 0; i < ReelLength; i++)
        {
            Vector3 slotPosition = new Vector3(2, transform.position.y + reelHeight + i * 2,
                transform.position.z);
            int randomNumber = UnityEngine.Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 75)
            {
                GameObject newSmallBoy = Instantiate(SmallBoy, slotPosition, Quaternion.identity, newReelThree);
                r3.SlotReelThree.Add(newSmallBoy);
            }
            else if (randomNumber >= 76 && randomNumber < 100)
            {
                GameObject newBigBoy = Instantiate(BigBoy, slotPosition, Quaternion.identity, newReelThree);
                r3.SlotReelThree.Add(newBigBoy);
            }
        }
        CheckResults();
    }


    void CheckResults()
    {

        if (r1.SlotReelOne[reelHeight - 2].tag == r2.SlotReelTwo[reelHeight - 2].tag && r1.SlotReelOne[reelHeight - 2].tag == r3.SlotReelThree[reelHeight - 2].tag)
        {

            if (r1.SlotReelOne[reelHeight - 2].tag == "BigBoy")
            {
                Debug.Log("You win!");
                totalScore += 100;
            }
            else if (r1.SlotReelOne[reelHeight - 2].tag == "SmallBoy")
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
