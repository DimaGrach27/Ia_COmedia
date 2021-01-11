using UnityEngine;

public class Fire_Trap : MonoBehaviour
{
    [SerializeField] Sprite kfc;

    [SerializeField] SpriteRenderer player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.sprite = kfc;
        }
    }
}
