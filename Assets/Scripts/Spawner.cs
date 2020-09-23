using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Sprite> letterArray = new List<Sprite> {};


    private string firstLetter;
    private string secondLetter;
    private string thirdLetter;
    private string fourthLetter;
    private string fifthLetter;
    public Creator1 creator;

    private Creator1 creator1;
    private Creator1 creator2;
    private Creator1 creator3;
    private Creator1 creator4;
    private Creator1 creator5;

    private List<int> indexList = new List<int>();
    private int amountCreators;
    private int mode;

    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("difficulty");
        if (mode == (int)Difficulty.difficulty.hard)
        {
            amountCreators = 5;
            creator1 = Instantiate(creator, new Vector3(0f, 7f, 0f), Quaternion.identity);
            creator2 = Instantiate(creator, new Vector3(1.15f, 7f, 0f), Quaternion.identity);
            creator3 = Instantiate(creator, new Vector3(-1.15f, 7f, 0f), Quaternion.identity);
            creator4 = Instantiate(creator, new Vector3(2.4f, 7f, 0f), Quaternion.identity);
            creator5 = Instantiate(creator, new Vector3(-2.4f, 7f, 0f), Quaternion.identity);
        }
        else if (mode == (int)Difficulty.difficulty.medium)
        {
            amountCreators = 4;
            creator1 = Instantiate(creator, new Vector3(.667f, 7f, 0f), Quaternion.identity);
            creator2 = Instantiate(creator, new Vector3(-.667f, 7f, 0f), Quaternion.identity);
            creator3 = Instantiate(creator, new Vector3(2f, 7f, 0f), Quaternion.identity);
            creator4 = Instantiate(creator, new Vector3(-2f, 7f, 0f), Quaternion.identity);
        }
        else
        {
            amountCreators = 3;
            creator1 = Instantiate(creator, new Vector3(0f, 7f, 0f), Quaternion.identity);
            creator2 = Instantiate(creator, new Vector3(2f, 7f, 0f), Quaternion.identity);
            creator3 = Instantiate(creator, new Vector3(-2f, 7f, 0f), Quaternion.identity);
        }
        
        InvokeRepeating("SetLetters", 0f, 5f);
    }

    void SetLetters()
    {
        while (indexList.Count < amountCreators)
        {
            int num = Random.Range(0, letterArray.Count);

            if (!indexList.Contains(num) && indexList.Count < amountCreators - 2)
            {
                if (num != 0 && num != 4 && num != 8 && num != 14 && num != 20)
                {
                    indexList.Add(num);
                }
            }
            else if (!indexList.Contains(num))
            {
                indexList.Add(num);
            }
        }

        int correctLetter = Random.Range(0, amountCreators - 1);

        if (correctLetter == 0)
        {
            creator1.CreateWord(letterArray[indexList[0]], true);
        }
        else
        {
            creator1.CreateWord(letterArray[indexList[0]], false);
        }

        if (correctLetter == 1)
        {
            creator2.CreateWord(letterArray[indexList[1]], true);
        }
        else
        {
            creator2.CreateWord(letterArray[indexList[1]], false);
        }

        if (correctLetter == 2)
        {
            creator3.CreateWord(letterArray[indexList[2]], true);
        }
        else
        {
            creator3.CreateWord(letterArray[indexList[2]], false);
        }

        if (correctLetter == 3)
        {
            creator4.CreateWord(letterArray[indexList[3]], true);
        }
        else if (mode > 0)
        {
            creator4.CreateWord(letterArray[indexList[3]], false);
        }

        if (correctLetter == 4)
        {
            creator5.CreateWord(letterArray[indexList[4]], true);
        }
        else if (mode == (int)Difficulty.difficulty.hard)
        {
            creator5.CreateWord(letterArray[indexList[4]], false);
        }
        indexList.Clear();
    }
}
