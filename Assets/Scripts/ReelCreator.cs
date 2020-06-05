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
    private int targetYPosition = -15;

    private int totalScore = 0;
    public bool slotsSpun = false;
    // Start is called before the first frame update

    void Start()
    {
        Transform thisTransform = GetComponent<Transform>();
        slotsSpun = true;
        SlotsPicker();
        InstantiateIcons();

    }
    void Update()
    {
        StartCoroutine(AnimateSlots());
    }


    private void InstantiateIcons()
    {
        /*
        Vector3 slot1Position1 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 slot1Position2 = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        Vector3 slot1Position3 = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
        Vector3 slot1Position4 = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);
        Vector3 slot1Position5 = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 slot2Position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        Vector3 slot2Position2 = new Vector3(transform.position.x + 2, transform.position.y + 2, transform.position.z);
        Vector3 slot2Position3 = new Vector3(transform.position.x + 2, transform.position.y + 4, transform.position.z);
        Vector3 slot2Position4 = new Vector3(transform.position.x + 2, transform.position.y + 6, transform.position.z);
        Vector3 slot2Position5 = new Vector3(transform.position.x + 2, transform.position.y + 8, transform.position.z);
        Vector3 slot3Position1 = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
        Vector3 slot3Position2 = new Vector3(transform.position.x + 4, transform.position.y + 2, transform.position.z);
        Vector3 slot3Position3 = new Vector3(transform.position.x + 4, transform.position.y + 4, transform.position.z);
        Vector3 slot3Position4 = new Vector3(transform.position.x + 4, transform.position.y + 6, transform.position.z);
        Vector3 slot3Position5 = new Vector3(transform.position.x + 4, transform.position.y + 8, transform.position.z);

        for (int i = 0; i < ReelLength; i++)
        {
            {
                Instantiate(reel1[0], slot1Position1, Quaternion.identity);
                Instantiate(reel1[1], slot1Position2, Quaternion.identity);
                Instantiate(reel1[2], slot1Position3, Quaternion.identity);
                Instantiate(reel1[3], slot1Position4, Quaternion.identity);
                Instantiate(reel1[4], slot1Position5, Quaternion.identity);

                Instantiate(reel2[0], slot2Position, Quaternion.identity);
                Instantiate(reel2[1], slot2Position2, Quaternion.identity);
                Instantiate(reel2[2], slot2Position3, Quaternion.identity);
                Instantiate(reel2[3], slot2Position4, Quaternion.identity);
                Instantiate(reel2[4], slot2Position5, Quaternion.identity);

                Instantiate(reel3[0], slot3Position1, Quaternion.identity);
                Instantiate(reel3[1], slot3Position2, Quaternion.identity);
                Instantiate(reel3[2], slot3Position3, Quaternion.identity);
                Instantiate(reel3[3], slot3Position4, Quaternion.identity);
                Instantiate(reel3[4], slot3Position5, Quaternion.identity);
            }
        */
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

    IEnumerator AnimateSlots()
    {
        var newReelOne = GameObject.Find("Reel One").transform;
        var newReelTwo = GameObject.Find("Reel Two").transform;
        var newReelThree = GameObject.Find("Reel Three").transform;

        if (slotsSpun == true)
        {
            newReelOne.transform.Translate(Vector3.down * 3 * Time.deltaTime);
            yield return new WaitForSeconds(0.2f);
            newReelTwo.transform.Translate(Vector3.down * 3 * Time.deltaTime);
            yield return new WaitForSeconds(0.2f);
            newReelThree.transform.Translate(Vector3.down * 3 * Time.deltaTime);
        }

        if (newReelOne.position.y <= targetYPosition)
        {
            newReelOne.position = reelOneTargetPosition;
        }
        if (newReelTwo.position.y <= targetYPosition)
        {
            newReelTwo.position = reelTwoTargetPosition;
        }
        if (newReelThree.position.y <= targetYPosition)
        {
            newReelThree.position = reelThreeTargetPosition;
        }
    }

    void TurnSlotsOff()
    {
        slotsSpun = false;
    }



}
