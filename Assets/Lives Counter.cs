using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounter : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

    public void LoseLife()
    {
        //decrease livesRemaining value
        livesRemaining--;
        lives[livesRemaining].enabled = false; //hide images


        if (livesRemaining==0)
        {
            Debug.Log("Loser!");
        }
    }
    public void GainLife()
    {
        if (livesRemaining < lives.Length) // Ensure you don't go beyond the array length
        {
            // Increase livesRemaining value
            lives[livesRemaining].enabled = true; // Show images
            livesRemaining++;
        }
    }

}
