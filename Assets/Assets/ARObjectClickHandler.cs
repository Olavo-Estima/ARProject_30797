using UnityEngine;
using System.Collections;

public class ARObjectClickHandler : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                { 
                    var obj =   Instantiate(objectToSpawn, 
                                hit.transform.position,
                                Quaternion.identity);
                    Instantiate(objectToSpawn2,
                                hit.transform.position,
                                Quaternion.identity);
                    Destroy(gameObject);
                    Destroy(obj, 5);
                }
            }
        }
    }
}
