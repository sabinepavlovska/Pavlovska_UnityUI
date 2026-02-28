using System;
using TMPro;
using UnityEngine;

public class AgeForm : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField yearInput;
    [SerializeField] private TMP_Text resultText;

    public void ShowResult()
    {
        string name = nameInput.text.Trim();
        string yearStr = yearInput.text.Trim();

        if (string.IsNullOrEmpty(name))
        {
            resultText.text = "Lūdzu ievadi vārdu.";
            return;
        }

        if (!int.TryParse(yearStr, out int birthYear))
        {
            resultText.text = "Dzimšanas gads jāievada ar cipariem.";
            return;
        }

        int age = DateTime.Now.Year - birthYear;

        if (age < 0 || age > 130)
        {
            resultText.text = "Lūdzu ievadi dzimšanas gadu.";
            return;
        }

        resultText.text = $"Supervaronis {name} ir {age} gadus vecs!";
    }
}