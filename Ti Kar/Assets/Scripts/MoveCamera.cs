using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform flyPoints;
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(flyPoints != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, flyPoints.position, speed * Time.deltaTime);
        }
    }
}
