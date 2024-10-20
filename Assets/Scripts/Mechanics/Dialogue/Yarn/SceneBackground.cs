using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBackground : MonoBehaviour
{
    public SpriteRenderer sceneBackground;
    public SpriteRenderer[] background = {};

    private void Start() {
        sceneBackground = GetComponent<SpriteRenderer>();
    }
    [YarnCommand ("SceneBG")]
    public void SceneBG (string background)
    {
        switch (background) 
        {
            case "intro":
                sceneBackground = background[0];
            break;

            case "hallway":
                sceneBackground = background[1];
            break;

            case "classroom":
                sceneBackground = background[2];
            break;

            default:
                sceneBackground = background[0];
            break;
        }
    }
}
