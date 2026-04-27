using UnityEngine;

public class PLAYERINTERACTION : MonoBehaviour
{
    public float interactionDistance = 3f;
    public LayerMask interacterableLayer;
    public Transform Eyes;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(Eyes.position, Eyes.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance, interacterableLayer))
            {
                Debug.Log("Hit" + hit.transform.name);
            }
        }
    }
}
