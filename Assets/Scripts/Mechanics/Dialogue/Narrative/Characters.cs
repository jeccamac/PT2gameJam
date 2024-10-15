using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Mechanics.Dialog
{
    [CreateAssetMenu(menuName = "Narrative/Character Pool")]
    public class Characters : ScriptableObject
    {
        [SerializeField]
        List<CharacterExpressions> _characters = new List<CharacterExpressions>();

        /*
        <summary>
        Provides a dictionary-like interface to <see cref="_characters"/>. Returns null in unable to find the requested character.
        </summary>
        <param name="characterName"></param>
        <returns></returns>
        */

        public CharacterExpressions GetCharacter(string characterName)
        {
            foreach (CharacterExpressions character in _characters)
            {
                if (character != null && characterName.ToLower() == character.CharacterName.ToLower())
                {
                    return character;
                }
            }
            return null;
        }
    }
}
