using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    DefenderButton[] buttons;

    private void OnMouseDown()
    {
        TurnOffButtons(buttons);
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);

    }

    private void TurnOffButtons(DefenderButton[] buttons)
    {
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
    }

    private void Start()
    {
       buttons = FindObjectsOfType<DefenderButton>();
        TurnOffButtons(buttons);
    }
}
