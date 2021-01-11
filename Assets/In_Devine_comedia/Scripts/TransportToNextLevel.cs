using UnityEngine;
using UnityEngine.Playables;

public class TransportToNextLevel : MonoBehaviour
{
    [SerializeField] GameObject canv_toWin;
    [SerializeField] PlayableDirector EndCatScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && First_Dialog_Haron.isAnswer)
        {
            canv_toWin.SetActive(true);
        }
    }
    public void Wineble()
    {
        if (First_Dialog_Haron.isAnswer)
        {
            Player_Movents.isControl = false;
            EndCatScene.Play();
        }
    }
}
