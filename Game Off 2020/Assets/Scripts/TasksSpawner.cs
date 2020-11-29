using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksSpawner : MonoBehaviour
{
    public Transform[] WPA;
    public Transform[] WPB;
    public Transform[] WPC;
    public Transform[] WPD;
    public Transform[] WPE;

    public GameObject[] ObjsA;
    public GameObject[] ObjsB;
    public GameObject[] ObjsC;
    public GameObject[] ObjsD;
    public GameObject[] ObjsE;

    private int posA;
    private int posB;
    private int posC;
    private int posD;
    private int posE;

    private int posWPA;
    private int posWPB;
    private int posWPC;
    private int posWPD;
    private int posWPE;

    void Awake()
    {


        posA = UnityEngine.Random.Range(0, 3);
        posB = UnityEngine.Random.Range(0, 3);
        posC = UnityEngine.Random.Range(0, 3);
        posD = UnityEngine.Random.Range(0, 3);
        posE = UnityEngine.Random.Range(0, 3);


        posWPA = UnityEngine.Random.Range(0, 3);
        posWPB = UnityEngine.Random.Range(0, 3);
        posWPC = UnityEngine.Random.Range(0, 3);
        posWPD = UnityEngine.Random.Range(0, 3);
        posWPE = UnityEngine.Random.Range(0, 3);


        Instantiate(ObjsA[posA], WPA[posWPA]);
        Instantiate(ObjsB[posB], WPB[posWPB]);
        Instantiate(ObjsC[posC], WPC[posWPC]);
        Instantiate(ObjsD[posD], WPD[posWPD]);
        Instantiate(ObjsE[posE], WPE[posWPE]);
    }
}
