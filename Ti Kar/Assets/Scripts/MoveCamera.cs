using UnityEngine;
using UnityEngine.Events;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform flyPoints;
    [SerializeField] float speed;
    [SerializeField] GameObject finishPhasePainel;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            finishPhasePainel.SetActive(true);
            print("Colidiu");
        }
    }
}
