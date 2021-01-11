using UnityEngine;

public class First_Dialog_Haron : MonoBehaviour
{
    public static bool isAnswer;
    [SerializeField] GameObject firstText;
    [SerializeField] GameObject secText;
    [SerializeField] GameObject ansverText;

    public void NextWind()
    {
        firstText.SetActive(false);
        secText.SetActive(true);
    }

    private void Update()
    {
        if (isAnswer)
        {
            firstText.SetActive(false);
            secText.SetActive(false);
            ansverText.SetActive(true);
        }
    }
}
