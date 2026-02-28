using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    [SerializeField] private WardrobeManager wardrobeManager;

    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;
        if (dragged == null) return;

        var draggable = dragged.GetComponent<DraggableItem>();
        var itemUI = dragged.GetComponent<EquipmentItemUI>();

        if (draggable == null) return;


        if (wardrobeManager != null && itemUI != null)
            wardrobeManager.Equip(itemUI.slotType, itemUI.sprite);


        draggable.ResetToOriginal();
    }
}