using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{

    public TextMeshProUGUI keytext;
    public TextMeshProUGUI doortext;



    public bool keyCheck = false;

    // Start is called before the first frame update
    void Start()
    {
       keyCheck = false;
        PlayerPrefs.SetInt("key", 0);
    }

}
