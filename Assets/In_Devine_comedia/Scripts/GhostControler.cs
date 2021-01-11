using UnityEngine;

public class GhostControler : MonoBehaviour
{
    private bool isActiveDialogWind;

    [SerializeField] GameObject DialogWind;
    [SerializeField] GameObject activeText;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isActiveDialogWind = true;
            activeText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isActiveDialogWind = false;
            activeText.SetActive(false);
            DialogWind.SetActive(false);

        }
    }

    public void ActiveDialogWindow()
    {
        if (isActiveDialogWind)
        {
            First_Dialog_Haron.isAnswer = true;
            activeText.SetActive(false);
            DialogWind.SetActive(true);
        }
    }
}
