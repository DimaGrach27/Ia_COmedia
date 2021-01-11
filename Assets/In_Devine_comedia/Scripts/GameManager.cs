using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvasDialog;

    [SerializeField] SpriteRenderer player;
    [SerializeField] Material norm;
    [SerializeField] Renderer rer;

    private void Update()
    {
        Debug.Log(rer.material.GetFloat("Vector1_3978D4E6"));
        if(Time.time > 1f)
        {
            player.material = norm;
        }
    }

    public void CloseWindow()
    {
        canvasDialog.SetActive(false);
    }

    public void LOadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
