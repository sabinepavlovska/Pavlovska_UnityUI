using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    [SerializeField] private CharacterSelector characterSelector;
    [SerializeField] private GameObject characterA; 
    [SerializeField] private GameObject characterB; 
    [SerializeField] private Slider heightSlider;
    [SerializeField] private Slider widthSlider;

    private void Start()
    {
        heightSlider.onValueChanged.AddListener(OnHeightChanged);
        widthSlider.onValueChanged.AddListener(OnWidthChanged);
    }

    private void OnHeightChanged(float value)
    {
        Transform character = GetCurrentCharacter();
        if (character == null) return;

        Vector3 scale = character.localScale;
        scale.y = value;
        character.localScale = scale;
    }

    private void OnWidthChanged(float value)
    {
        Transform character = GetCurrentCharacter();
        if (character == null) return;

        Vector3 scale = character.localScale;
        scale.x = value;
        character.localScale = scale;
    }

    private Transform GetCurrentCharacter()
    {
        if (characterSelector.CurrentCharacterType == CharacterType.Girl)
            return characterA.transform;

        return characterB.transform;
    }
}