using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour
{
    public void PointerEnter() {
        if (gameObject.GetComponent<Animator>().GetBool("open"))
            PointerExit();
        else
            gameObject.GetComponent<Animator>().SetBool("open", true);
    }
    public void PointerExit() {
        gameObject.GetComponent<Animator>().SetBool("open", false);
    }
}
