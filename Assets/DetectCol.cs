using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCol : MonoBehaviour
{
    private int P1 = 0;
    public Text player1;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {

            P1 = P1 + 1;

            // Get a reference to the ChangeMaterialColor script
            ChangeMaterialColor changeColorScript = other.gameObject.GetComponent<ChangeMaterialColor>();

            // If the script exists, call its ChangeToRandomColor method
            if (changeColorScript != null)
            {
                changeColorScript.ChangeToRandomColor();
            }

            Debug.Log("Player 1 Score: " + P1);
            player1.text = "Player 1: " + P1.ToString();

    }
}


