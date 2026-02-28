using TMPro;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GameObject characterA;
    [SerializeField] private GameObject characterB;

    public CharacterType CurrentCharacterType { get; private set; }

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
        bool isBoy = index == 0;

               CurrentCharacterType = isBoy ? CharacterType.Boy : CharacterType.Girl;

        if (characterA != null) characterA.SetActive(isBoy);
        if (characterB != null) characterB.SetActive(!isBoy);
    }
}