using UnityEngine;

public class Boxxes : MonoBehaviour
{
   ErrorTXT errorTXT;

    private void Start()
    {
        errorTXT = FindAnyObjectByType<ErrorTXT>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            errorTXT.MaxErrorsController();
            errorTXT.startErrors++;
            Destroy(gameObject);
        }
    }
}
