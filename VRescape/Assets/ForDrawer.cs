using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForDrawer : Door
{

    // Start is called before the first frame update

    public void GetThisKey() { // �Լ��� ����� 
       
        PlayerPrefs.SetInt("key", 1); 
        ///Ű�� 0�̸� false 1�̸� true
        keyCheck = true;
        Debug.Log("Ű ȹ��");
        keytext.text = "key : O";
        keytext.color = Color.yellow;
        Destroy(gameObject);
    }

}
