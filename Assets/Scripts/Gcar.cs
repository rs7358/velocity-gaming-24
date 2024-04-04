using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gcar : MonoBehaviour
{
    public static int CarType;
    public GameObject ChooseTrack;
    public void RedCar(){
        CarType = 1;
        ChooseTrack.SetActive(true);
    }
    public void BlueCar(){
        CarType = 2;
        ChooseTrack.SetActive(true);
    }
}
