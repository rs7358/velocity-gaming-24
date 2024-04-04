using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laps : MonoBehaviour
{
    public GameObject LapCounter;
    public int LapsDone;

    public GameObject RaceFinish;

    void Update(){
        if (LapsDone == 3){
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter (){
        LapsDone += 1;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;
    }
}
