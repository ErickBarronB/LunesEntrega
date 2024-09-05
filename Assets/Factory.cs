using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Factory : MonoBehaviour
{
    // Start is called before the first frame update
    public List<PowerUp> powerUps = new List<PowerUp>();
    private Dictionary<string, PowerUp> idPowerUp;
    PowerUp CurrentPowerUp;

    private void Awake()
    {
        idPowerUp = new Dictionary<string, PowerUp>();

        foreach (var powerUp in powerUps)
        {
           idPowerUp.Add(powerUp.ID, powerUp);
        }
    }

    public PowerUp Create(string id)
    {
        if(!idPowerUp.TryGetValue(id, out PowerUp powerUp))
        {
            return null;
        } 
        return powerUp;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed");
            string  currentId = idPowerUp.ElementAt(UnityEngine.Random.Range(0, idPowerUp.Count)).Key;
            CurrentPowerUp = Create(currentId);

            Instantiate(CurrentPowerUp, new Vector3(0, 1, 0), Quaternion.identity);
        }
       }
}
