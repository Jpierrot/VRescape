using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForDrawer : Door
{

    // Start is called before the first frame update

    public void GetThisKey() { // 함수는 동사로 
       
        PlayerPrefs.SetInt("key", 1); 
        ///키가 0이면 false 1이면 true
        keyCheck = true;
        Debug.Log("키 획득");
        keytext.text = "key : O";
        keytext.color = Color.yellow;
        Destroy(gameObject);
    }

}
