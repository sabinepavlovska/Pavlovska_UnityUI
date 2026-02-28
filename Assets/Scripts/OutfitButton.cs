using UnityEngine;

public class OutfitButton : MonoBehaviour
{
    [SerializeField] private WardrobeManager wardrobe;
    [SerializeField] private SlotType slot;
    [SerializeField] private Sprite spriteToEquip;

    public void OnClickEquip()
    {
        if (wardrobe == null) return;
        wardrobe.Equip(slot, spriteToEquip);
    }
}