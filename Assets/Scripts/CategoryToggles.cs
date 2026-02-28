using UnityEngine;
using UnityEngine.UI;

public class CategoryToggles : MonoBehaviour
{
    [SerializeField] private Toggle topsToggle;
    [SerializeField] private Toggle bottomToggle;
    [SerializeField] private Toggle accessoriesToggle;

    [SerializeField] private GameObject topsPanel;
    [SerializeField] private GameObject bottomPanel;
    [SerializeField] private GameObject accessoriesPanel;

    private void Start()
    {
        if (topsToggle != null)
            topsToggle.onValueChanged.AddListener(v => { if (topsPanel != null) topsPanel.SetActive(v); });

        if (bottomToggle != null)
            bottomToggle.onValueChanged.AddListener(v => { if (bottomPanel != null) bottomPanel.SetActive(v); });

        if (accessoriesToggle != null)
            accessoriesToggle.onValueChanged.AddListener(v => { if (accessoriesPanel != null) accessoriesPanel.SetActive(v); });

        
        if (topsPanel != null && topsToggle != null) topsPanel.SetActive(topsToggle.isOn);
        if (bottomPanel != null && bottomToggle != null) bottomPanel.SetActive(bottomToggle.isOn);
        if (accessoriesPanel != null && accessoriesToggle != null) accessoriesPanel.SetActive(accessoriesToggle.isOn);
    }
}