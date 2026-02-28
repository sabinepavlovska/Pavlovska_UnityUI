using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup cg;
    private RectTransform rt;

    private Transform originalParent;
    private Vector2 originalAnchoredPos;
    private RectTransform canvasRoot;

    private void Awake()
    {
        cg = GetComponent<CanvasGroup>();
        rt = GetComponent<RectTransform>();

        var canvas = GetComponentInParent<Canvas>();
        canvasRoot = canvas != null ? canvas.transform as RectTransform : null;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (canvasRoot == null) return;

        originalParent = transform.parent;
        originalAnchoredPos = rt.anchoredPosition;

        cg.blocksRaycasts = false;
        transform.SetParent(canvasRoot, true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rt.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        cg.blocksRaycasts = true;

        // Ja netika nomests drop-zon?, atgrie?am atpaka?
        if (transform.parent == canvasRoot)
            ResetToOriginal();
    }

    public void ResetToOriginal()
    {
        transform.SetParent(originalParent, false);
        rt.anchoredPosition = originalAnchoredPos;
        rt.localRotation = Quaternion.identity;
        rt.localScale = Vector3.one;
    }
}