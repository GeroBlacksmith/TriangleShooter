using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SampleScript : MonoBehaviour
{
    
    private void Start()
    {
        AnonimousTypesExample();
    }

    private void AnonimousTypesExample()
    {
        var enemies = new[]
        {
            new {name="Monster", hitPoints=250},
            new {name="Ghoblin", hitPoints=50},
            new {name="Beast", hitPoints=500}
        };

        var enemyQuery =
            from enemy in enemies
            orderby enemy.name
            select enemy;

        foreach (var enemy in enemyQuery)
        {
            Debug.Log(enemy.name);
        }
    }
}
