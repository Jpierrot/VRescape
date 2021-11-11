using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour
{
    public void PointerEnter() {
        if(gameObject.GetComponent<Animator>().GetBool("open"))
            PointerExit();
        else
            PointIn();
    }
    public void PointerExit() {
        gameObject.GetComponent<Animator>().SetBool("open", false);
    }

    public void PointIn() {
        gameObject.GetComponent<Animator>().SetBool("open", true);
    }
}
