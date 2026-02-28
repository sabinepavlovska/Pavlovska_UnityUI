using TMPro;
using UnityEngine;

public class DescriptionPanelController : MonoBehaviour
{
    [SerializeField] private CharacterSelector characterSelector;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text bodyText;

    [Header("Girl")]
    [TextArea(2, 6)] public string girlTitle = "Girl – Summer Outfit";
    [TextArea(5, 15)]
    public string girlBody =
        "Light and colorful summer outfit.\n\n• Top\n• Bottom\n• Shoes\n• Accessories\n\nTip: Drag items onto the character.";

    [Header("Boy")]
    [TextArea(2, 6)] public string boyTitle = "Boy – Summer Outfit";
    [TextArea(5, 15)]
    public string boyBody =
        "Comfortable and sporty style.\n\n• T-shirt\n• Shorts\n• Shoes\n• Accessories\n\nTip: Use toggles to filter categories.";

    private void OnEnable()
    {
        if (characterSelector != null)
            characterSelector.OnCharacterChanged += UpdateDescription;
    }

    private void OnDisable()
    {
        if (characterSelector != null)
            characterSelector.OnCharacterChanged -= UpdateDescription;
    }

    private void Start()
    {
        if (characterSelector != null)
            UpdateDescription(characterSelector.CurrentCharacterType);
    }

    private void UpdateDescription(CharacterType type)
    {
        if (titleText == null || bodyText == null) return;

        if (type == CharacterType.Girl)
        {
            titleText.text = girlTitle;
            bodyText.text = girlBody;
        }
        else
        {
            titleText.text = boyTitle;
            bodyText.text = boyBody;
        }
    }
}