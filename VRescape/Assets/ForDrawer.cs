using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForDrawer : Door
{
    public Button keybutton;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        keybutton.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        keybutton.gameObject.SetActive(false);
    }

    public void GetThisKey() { // ÇÔ¼ö´Â µ¿»ç·Î 
        Debug.Log("Å° È¹µæ");
        keyCheck = true;
        Destroy(gameObject);
    }



}
