using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

namespace Mechanics.Dialog
{
    [CreateAssetMenu(menuName = "Narrative/Character")]
    public class CharacterExpressions : ScriptableObject
    {
        public string CharacterName = string.Empty;

        [SerializeField]
        List<Sprite> _sprites = null;

        [Header("Options")]
        public bool ShowPortrait = true;
        public bool ShowName = true;

        /*
        <summary>
        Finds the corresponding sprite for paramref name="emotion"/> from <see cref=>_sprites"/>.
        </summary>
        <param name="emotion"></param>
        <returns>null if unable to find it.</returns>
        */
        public Sprite GetSprite(CharacterEmotion emotion)
        {
            if (_sprites.Count == 0)
            {
                Debug.LogWarning($"character file \"{name}\". {CharacterName} has no sprites.");
                return null;
            }
            else if ((int)emotion >= _sprites.Count)
            {
                Debug.LogWarning($"character file \"{name}\". {CharacterName} does not have the sprite for {emotion}.");
                return null;
            }
            return _sprites[(int)emotion];
        }

        public static CharacterEmotion StringToEmotion(string str)
        {
            switch (str.ToLower())
            {
                case "idle":
                    return CharacterEmotion.Idle;

                case "irritated":
                    return CharacterEmotion.Irritated;

                case "thinking":
                    return CharacterEmotion.Thinking;

                case "shock":
                    return CharacterEmotion.Shock;

                default:
                    Debug.LogWarning($"Unable to find CharacterEmotion for {str}");
                    return CharacterEmotion.Idle;
            }
        }
        public enum CharacterEmotion
        {
            Idle = 0, Irritated = 1, Thinking = 2, Shock = 3, Wild = 4
        }
    }
}
