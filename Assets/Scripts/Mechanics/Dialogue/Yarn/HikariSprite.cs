using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HikariSprite : MonoBehaviour
{
    public GameObject position;
    public SpriteRenderer sprite;

    [YarnCommand("Hikari")]
    public void Hikari(GameObject pos, string expression)
    {
        if (pos != null)
        {

        }

        switch (expression)
        {
            case "idle":
                
            break;

            case "irritated":
            break;

            case "shock":
            break;

            case "thinking":
            break;

            case "wild":
            break;

            default:
            break;
        }
    }
}
