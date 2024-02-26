using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCol2 : MonoBehaviour
{
    private int P2 = 0;
    public Text player2;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other2)
    {

            P2 = P2 + 1;

            // Get a reference to the ChangeMaterialColor script
            ChangeMaterialColor changeColorScript = other2.gameObject.GetComponent<ChangeMaterialColor>();

            // If the script exists, call its ChangeToRandomColor method
            if (changeColorScript != null)
            {
                changeColorScript.ChangeToRandomColor();
            }

            Debug.Log("Player 2 Score: " + P2);
            player2.text = "Player 2: " + P2.ToString();

    }
}
