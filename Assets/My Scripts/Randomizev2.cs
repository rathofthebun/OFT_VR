using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Randomizev2 : MonoBehaviour
{
    // Creating a HashSet of odd numbers 
    HashSet<int> levels = new HashSet<int>();
    private int numlevel = 7;
    private static bool created = false;
    private int nextLevel = 0;


    void Start()
    {
        LevelPick();
        }

    void LevelPick(){
        while (levels.Count != numlevel)
        {
            int randNum = UnityEngine.Random.Range(1, numlevel+1);
            //Debug.Log(randNum + " = generated");
            if (levels.Add(randNum))
            {
                nextLevel = randNum;
                Debug.Log("level: " + (nextLevel) + " picked");
                break;
            }
        }
    }

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
            {
                SceneManager.LoadScene(nextLevel);
                LevelPick();
            }
    }

    }
