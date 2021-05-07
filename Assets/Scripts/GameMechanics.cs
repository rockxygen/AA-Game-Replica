using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{

    private bool gameHasEnded = false;

    public CircleController rotator;
    public PinCreator creator;

    public Animator animator;

    public void LostGame()
    {
        if (gameHasEnded)
        {
            return;
        }

        rotator.enabled = false;
        creator.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("You lose!!!");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
