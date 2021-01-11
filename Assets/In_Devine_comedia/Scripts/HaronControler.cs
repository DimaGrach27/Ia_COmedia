using UnityEngine;

public class HaronControler : MonoBehaviour
{
    [SerializeField] GameObject question;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            question.SetActive(true);
        }
    }
}
