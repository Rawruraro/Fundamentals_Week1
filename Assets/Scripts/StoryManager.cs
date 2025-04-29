using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StoryManager : MonoBehaviour
{
    public TextMeshProUGUI KindnessValue;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject EscapeEnding;
    public GameObject PerishEnding;
    public GameObject RescuedEnding;
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


    public void PerishEnd()
    {
        Page2.SetActive(false);
        PerishEnding.SetActive(true);
    }

    public void EscapeEnd()
    {
        Page2.SetActive(false);
        EscapeEnding.SetActive(true);
    }

    public void RescuedEnd()
    {
        Page2.SetActive(false);
        Page1.SetActive(false);
        RescuedEnding.SetActive(true);
    }

    public void Restart()
    {
        Page1.SetActive(true);
        EscapeEnding.SetActive(false);
        RescuedEnding.SetActive(false);
        PerishEnding.SetActive(false);
    }
}
