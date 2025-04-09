using UnityEngine;

public class Explosions : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] Transform bombTransform;
    [SerializeField] float bombTimeRate;

    private float nextToDrop;

    void Update()
    {
        
        if(Time.deltaTime >= nextToDrop)
        {
            OnMouseDown();
            nextToDrop = Time.deltaTime + bombTimeRate;

        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bomb, mousePosition, Quaternion.identity);
        }
        
    }
     
    
}
