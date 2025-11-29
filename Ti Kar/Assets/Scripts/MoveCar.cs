using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField] Transform[] obstaclePoint;
    [SerializeField] float speed;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(0, obstaclePoint.Length);
        
    }
}
