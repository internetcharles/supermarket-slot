using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class ReelCreator : MonoBehaviour
{

    SmallBoy smallBoy;
    BigBoy bigBoy;

    [SerializeField] private GameObject[] Reel1Icons = default;
    [SerializeField] private GameObject[] Reel2Icons = default;
    [SerializeField] private GameObject[] Reel3Icons = default;
    [SerializeField] private int ReelLength = default;

    public List<GameObject> reel1 = new List<GameObject>();
    public List<GameObject> reel2 = new List<GameObject>();
    public List<GameObject> reel3 = new List<GameObject>();

    private int totalScore = 0;
    // Start is called before the first frame update

    void Start()
    {
        GenerateSlots();
        InstantiateIcons();
        CheckResults();
    }

    private void InstantiateIcons()
    {
        Vector3 slot2Position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        Vector3 slot3Position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);

        Instantiate(reel1[0], transform.position, Quaternion.identity);
        Instantiate(reel2[0], slot2Position, Quaternion.identity);
        Instantiate(reel3[0], slot3Position, Quaternion.identity);

    }

    private void GenerateSlots()
    {
        for (int i = 0; i < ReelLength; i++)
        {
            int randomIconReel1 = Random.Range(0, Reel1Icons.Length);
            int randomIconReel2 = Random.Range(0, Reel2Icons.Length);
            int randomIconReel3 = Random.Range(0, Reel3Icons.Length);
            reel1.Add(Reel1Icons[randomIconReel1] as GameObject);
            reel2.Add(Reel2Icons[randomIconReel2] as GameObject);
            reel3.Add(Reel3Icons[randomIconReel3] as GameObject);
        }
        GameObject firstIcon = GameObject.Find(reel1[0].ToString());
    }

    private void CheckResults()
    {
        if (reel1[0] == reel2[0] && reel1[0] == reel3[0])
        {
            Debug.Log("You win!");
            if (reel1[0] == GameObject.FindGameObjectWithTag("BigBoy"))
            {
                totalScore += 100;
            }
            else if (GameObject.FindGameObjectWithTag("SmallBoy"))
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
