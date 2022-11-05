using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasySaveState : MonoBehaviour
{
    public Transform box;
    public void OnSaveClick()
    {
        ES3.Save<int>("score", 5);
        ES3.Save<string>("playername", "batman");
        ES3.Save<Transform>("transformbox", box);
    }

    public void OnLoadClick()
    {
        int score = ES3.Load<int>("score", 0);
        ES3Settings settings = new ES3Settings();
        // if nothing is save then it would load superman
        string name = ES3.Load<string>("playername", "superman", settings);
        ES3.LoadInto<Transform>("transformbox", box);
    }
}
