using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class spriteAnimate : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   //below is the declared animation
    public Animator ChichiWalk;
    public Animator ChichiIdle;
    //below is when the pointer enters, it will set the value of a behaviour to true. And vice versa.
    public void OnPointerEnter(PointerEventData eventData)
    {
        ChichiWalk.SetBool("isWalking", true);
        ChichiWalk.SetBool("isIdle", false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ChichiWalk.SetBool("isWalking", false);
        ChichiWalk.SetBool("isIdle", true);
    }

    // Start is called before the first frame update
    private void Start()
    {
        ChichiWalk = GetComponent<Animator>();
        ChichiIdle = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
