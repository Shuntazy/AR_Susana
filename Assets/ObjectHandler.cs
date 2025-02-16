using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
    public GameObject objectToSpawn;

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
                    //Instantiate(objectToSpawn,
                    //            hit.transform.position + new Vector3(0, 0.2f, 0),
                    //            Quaternion.identity);
                    hit.transform.GetComponent<Animator>().SetTrigger("anime");
                }
            }
        }
    }
}
