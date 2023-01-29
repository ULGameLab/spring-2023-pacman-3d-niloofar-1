using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfPellets { get; private set; }

    public void PelletCollected()
    {
        NumberOfPellets++;
    }
}
