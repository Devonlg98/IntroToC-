using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartTimer = 3f;

    public GameObject gotCheeseUI;
    public GameObject gotCatUI;

    public void gotCheese()
    {
        gotCheeseUI.SetActive(true);
    }

    public void gotCat()
    {
        gotCatUI.SetActive(true);
        Debug.Log("Game Won, You got the Cheese");
    }

    public void EndGame()
    {
        if(gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartTimer);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
