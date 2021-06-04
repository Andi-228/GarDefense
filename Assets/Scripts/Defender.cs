






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int startCost = 100;
    [SerializeField] int starsToEarn = 2;
    // Start is called before the first frame update

    public int GetStartCost() { return startCost; }

    public void AddStars(int amount)
    {
        FindObjectOfType<StarCounter>().AddStars(starsToEarn);
    }
    
}
