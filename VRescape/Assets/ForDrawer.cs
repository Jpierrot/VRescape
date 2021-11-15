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

    public void GetThisKey() { // �Լ��� ����� 
        Debug.Log("Ű ȹ��");
        keyCheck = true;
        Destroy(gameObject);
    }



}
