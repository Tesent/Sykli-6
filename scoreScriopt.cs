using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScriopt : MonoBehaviour
{
    public static int Points;
    Text score;

    // Update is called once per frame
    public void Start()
    {

        score = GetComponent<Text>();
    }

    void Update()
    {
        //Päivitä score näyttöön
        score.text = "Points :" + Points;
    }
}
