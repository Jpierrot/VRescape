using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clear : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI cleartext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        cleartext.transform.gameObject.SetActive(true);
        cleartext.text = "clear";
        Time.timeScale = 0;
    }


}
