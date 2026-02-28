using System;
using TMPro;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;

   
    [SerializeField] private GameObject characterA;
    [SerializeField] private GameObject characterB;

    public CharacterType CurrentCharacterType { get; private set; }

    
    public event Action<CharacterType> OnCharacterChanged;

    private void Start()
    {
        ApplySelection(dropdown.value);
        dropdown.onValueChanged.AddListener(ApplySelection);
    }

    private void OnDestroy()
    {
        if (dropdown != null)
            dropdown.onValueChanged.RemoveListener(ApplySelection);
    }

    private void ApplySelection(int index)
    {
       
        bool isGirl = index == 0;

        CurrentCharacterType = isGirl ? CharacterType.Girl : CharacterType.Boy;

        if (characterA != null) characterA.SetActive(isGirl);     
        if (characterB != null) characterB.SetActive(!isGirl);    

        OnCharacterChanged?.Invoke(CurrentCharacterType);
    }
}