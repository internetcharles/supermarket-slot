using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class ReelCreator : MonoBehaviour
{

    [SerializeField] GameObject SmallBoy = default;
    [SerializeField] GameObject BigBoy = default;
    [SerializeField] private int ReelLength = default;

    public List<GameObject> reel1 = new List<GameObject>();
    public List<GameObject> reel2 = new List<GameObject>();
    public List<GameObject> reel3 = new List<GameObject>();

    private int totalScore = 0;
    // Start is called before the first frame update

    void Start()
    {
        SlotsPicker();
        InstantiateIcons();
        CheckResults();
    }

    private void InstantiateIcons()
    {
        Vector3 slot1Position2 = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        Vector3 slot1Position3 = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
        Vector3 slot1Position4 = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);
        Vector3 slot1Position5 = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 slot2Position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        Vector3 slot2Position2 = new Vector3(transform.position.x + 2, transform.position.y + 2, transform.position.z);
        Vector3 slot2Position3 = new Vector3(transform.position.x + 2, transform.position.y + 4, transform.position.z);
        Vector3 slot2Position4 = new Vector3(transform.position.x + 2, transform.position.y + 6, transform.position.z);
        Vector3 slot2Position5 = new Vector3(transform.position.x + 2, transform.position.y + 8, transform.position.z);
        Vector3 slot3Position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
        Vector3 slot3Position2 = new Vector3(transform.position.x + 4, transform.position.y + 2, transform.position.z);
        Vector3 slot3Position3 = new Vector3(transform.position.x + 4, transform.position.y + 4, transform.position.z);
        Vector3 slot3Position4 = new Vector3(transform.position.x + 4, transform.position.y + 6, transform.position.z);
        Vector3 slot3Position5 = new Vector3(transform.position.x + 4, transform.position.y + 8, transform.position.z);


        Instantiate(reel1[0], transform.position, Quaternion.identity);
        Instantiate(reel1[1], slot1Position2, Quaternion.identity);
        Instantiate(reel1[2], slot1Position3, Quaternion.identity);
        Instantiate(reel1[3], slot1Position4, Quaternion.identity);
        Instantiate(reel1[4], slot1Position5, Quaternion.identity);

        Instantiate(reel2[0], slot2Position, Quaternion.identity);
        Instantiate(reel2[1], slot2Position2, Quaternion.identity);
        Instantiate(reel2[2], slot2Position3, Quaternion.identity);
        Instantiate(reel2[3], slot2Position4, Quaternion.identity);
        Instantiate(reel2[4], slot2Position5, Quaternion.identity);

        Instantiate(reel3[0], slot3Position, Quaternion.identity);
        Instantiate(reel3[1], slot3Position2, Quaternion.identity);
        Instantiate(reel3[2], slot3Position3, Quaternion.identity);
        Instantiate(reel3[3], slot3Position4, Quaternion.identity);
        Instantiate(reel3[4], slot3Position5, Quaternion.identity);


    }

    public void SlotsPicker()
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
        if (reel1[0] == reel2[0] && reel1[0] == reel3[0])
        {
            Debug.Log("You win!");
            if (reel1[0] == BigBoy)
            {
                totalScore += 100;
            }
            else if (reel1[0] == SmallBoy)
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



    void Update()
    {
        
    }

}
