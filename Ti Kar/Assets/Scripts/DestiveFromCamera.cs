using UnityEngine;

public class DestiveFromCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] LayerMask obstacleLayer;

    GameObject lastHitGameObject;
    Material originalMaterial;
    [SerializeField] Material transparentMaterial;

   void Update()
   {
        Vector3 direction = target.position - transform.position; 
        RaycastHit hit;

        if(Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity, obstacleLayer))
        {
            if(lastHitGameObject != hit.collider.gameObject)
            {
                ResetLastHitObject();

                lastHitGameObject = hit.collider.gameObject;
                originalMaterial = lastHitGameObject.GetComponent<Renderer>().material;
                lastHitGameObject.GetComponent<Renderer>().material = transparentMaterial;
            }
        }
        else
        {
            ResetLastHitObject();
        }
   }

    void ResetLastHitObject()
    {
        if(lastHitGameObject != null)
        {
            lastHitGameObject.GetComponent<Renderer>().material = originalMaterial;
            lastHitGameObject = null;
        }
    }
}
