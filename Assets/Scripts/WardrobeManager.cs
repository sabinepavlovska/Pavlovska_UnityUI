using UnityEngine;
using UnityEngine.UI;

public enum SlotType { Top, Bottom, Hat, Glasses }

public class WardrobeManager : MonoBehaviour
{
    [SerializeField] private CharacterSelector characterSelector;

    [Header("Girl layers")]
    [SerializeField] private Image girlTop;
    [SerializeField] private Image girlBottom;
    [SerializeField] private Image girlHat;
    [SerializeField] private Image girlGlasses;

    [Header("Boy layers")]
    [SerializeField] private Image boyTop;
    [SerializeField] private Image boyBottom;
    [SerializeField] private Image boyHat;
    [SerializeField] private Image boyGlasses;

    public void Equip(SlotType slot, Sprite sprite)
    {
        if (characterSelector == null || sprite == null) return;

        bool isBoy = characterSelector.CurrentCharacterType == CharacterType.Boy;
        Image target = GetTarget(slot, isBoy);

        if (target == null) return;

        target.sprite = sprite;
        target.gameObject.SetActive(true);
    }

    private Image GetTarget(SlotType slot, bool isBoy)
    {
        return slot switch
        {
            SlotType.Top => isBoy ? boyTop : girlTop,
            SlotType.Bottom => isBoy ? boyBottom : girlBottom,
            SlotType.Hat => isBoy ? boyHat : girlHat,
            SlotType.Glasses => isBoy ? boyGlasses : girlGlasses,
            _ => null
        };
    }
}