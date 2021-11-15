using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayInteraction : MonoBehaviour
{

    public Camera camera;

    Ray rayo;

  [SerializeField]
    private float maxray;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Rayshoot();
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(rayo.origin, rayo.direction);
    }

    void Rayshoot() {

        Vector3 camerapos = new Vector3(camera.gameObject.transform.position.x / 2, 
        camera.gameObject.transform.position.y / 2, 0);
        rayo = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(rayo, out hit, maxray)) {
            Debug.Log(hit.transform.name);
            GameObject temp = hit.transform.gameObject;
            Debug.Log("좆된 코드 : " + temp.name);
            
            switch(hit.transform.tag) {
                case "key" :
                    Debug.Log("이상한 코드 : " + temp.GetComponent<ForDrawer>());
                    temp?.GetComponent<ForDrawer>()?.GetThisKey();
                    break;
                default:
                    temp?.GetComponent<Interaction>()?.PointerEnter();
                    break;
            }
        } 
        


    }
  }

   
