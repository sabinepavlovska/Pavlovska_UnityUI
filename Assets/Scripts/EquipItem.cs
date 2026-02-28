using UnityEngine;
using UnityEngine.UI;

public class EquipItem : MonoBehaviour
{
    [Header("Allowed for")]
    public CharacterType allowedFor;

    [Header("Target layers")]
    public Image boyTargetLayer;
    public Image girlTargetLayer;

    [Header("Item sprite")]
    public Sprite itemSprite;

    private CharacterSelector characterSelector;

    private void Start()
    {
        characterSelector = FindFirstObjectByType<CharacterSelector>();
    }

    public void Equip()
    {
        if (characterSelector == null) return;

       
        if (characterSelector.CurrentCharacterType != allowedFor)
        {
            Debug.Log("Not allowed for this character.");
            return;
        }

               Image target = (characterSelector.CurrentCharacterType == CharacterType.Boy)
            ? boyTargetLayer
            : girlTargetLayer;

        if (target == null) return;

        target.sprite = itemSprite;
        target.gameObject.SetActive(true);
    }
}