using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteraction : MonoBehaviour
{
    Animator anim;

    public Camera camera;
    [SerializeField]
    private float maxray;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Rayshoot();
        }
    }

    void Rayshoot() {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, maxray)) {
            Debug.Log(hit.transform.name);
            switch (hit.transform.name) {
                case "door_01" :
                    anim.SetBool("doorOpen", true);
                    anim.SetBool("doorOpen", false);
                    break;
                case "door_02":
                    anim.SetBool("doorOpen", true);
                    anim.SetBool("doorOpen", false);
                    break;
                case "corpse_drawer 4":
                    anim.SetBool("drawerOpen", true);
                    anim.SetBool("drawerOpen", false);
                    break;
                default:
                    break;
            }
            
        }
    }

    
}
