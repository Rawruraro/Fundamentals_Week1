using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StoryManager : MonoBehaviour
{
    public TextMeshProUGUI KindnessValue;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject PicEnd;
    public GameObject EvilEnd;
    public GameObject LeaveEnd;
    public int Kindness;
    // Start is called before the first frame update
    void Start()
    { 
        Page1.SetActive(true);
        Page2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeavingScene()
    {
        Page2.SetActive(true);
        Page1.SetActive(false);
        Kindness = 3;
        KindnessValue.text = Kindness.ToString();
    }

    public void Beating()
    {
        Kindness = Kindness - 1;
        KindnessValue.text = Kindness.ToString();
        if (Kindness <= 0)
        {
            EvilEnding();
        }
        //show an image that gives Manong a black eye per punch and then a bloody nose on the last
    }

    public void EvilEnding()
    {
        Page2.SetActive(false);
        EvilEnd.SetActive(true);
    }

    public void LeaveEnding()
    {
        Page2.SetActive(false);
        LeaveEnd.SetActive(true);
    }

    public void PicEnding()
    {
        Page2.SetActive(false);
        Page1.SetActive(false);
        PicEnd.SetActive(true);
    }

    public void Restart()
    {
        Page1.SetActive(true);
        LeaveEnd.SetActive(false);
        PicEnd.SetActive(false);
        EvilEnd.SetActive(false);
    }
}
