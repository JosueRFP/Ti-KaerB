using UnityEngine;

public class Boxxes : MonoBehaviour
{
   ErrorTXT errorTXT;
    SendBoxTxt sendBoxTxt;

    private void Start()
    {
        errorTXT = FindAnyObjectByType<ErrorTXT>();
        sendBoxTxt = FindAnyObjectByType<SendBoxTxt>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            errorTXT.MaxErrorsController();
            errorTXT.startErrors++;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Deliverd"))
        {
            sendBoxTxt.UpdateBoxCount();
            Destroy(gameObject);
        }
    }
}
