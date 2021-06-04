using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    public void SetSelectedDefender(Defender selectedDefender)
    {
        defender = selectedDefender;
    }

    private void OnMouseDown()
    {
        Vector2 worldPos = GetSquareClicked();
        AttempToPlaceDefenderAt(worldPos);
    }

    private void AttempToPlaceDefenderAt(Vector2 worldPos)
    {
        var starsCounter = FindObjectOfType<StarCounter>();
        int defenderCost = defender.GetStartCost();
        if (starsCounter.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(worldPos);
            starsCounter.SpendStars(defenderCost);
        }
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        Defender newDefender = Instantiate(defender, worldPos, Quaternion.identity);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x,
                                       Input.mousePosition.y);
        Debug.Log("X = " + clickPos.x.ToString() + "Y = " + clickPos.y.ToString());

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Debug.Log("X = " + worldPos.x.ToString() + "Y = " + worldPos.y.ToString());
        Vector2 roundedPos = SnapToGrid(worldPos);
        return roundedPos;
    }

    private Vector2 SnapToGrid(Vector2 worldPos)
    {
        float newX = Mathf.RoundToInt(worldPos.x);
        float newY = Mathf.RoundToInt(worldPos.y);

        return new Vector2(newX, newY);
    }
}
