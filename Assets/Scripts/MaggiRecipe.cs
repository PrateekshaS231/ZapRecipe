using UnityEngine;
using TMPro;

public class MaggiRecipe : MonoBehaviour
{
    public TextMeshProUGUI stepsText;
    public StepModelController modelController;

    private string[] steps = {
        "Step 1: Boil 2 cups of water",
        "Step 2: Add the Masala mix and stir well",
        "Step 3: Add Maggi noodles and cook for 2 minutes",
        "Step 4: Cook until water is absorbed",
        "Step 5: Serve hot and enjoy!"
    };

    private int currentStep = 0;

    void Start()
    {
        ShowStep();
    }

    public void NextStep()
    {
        if (currentStep < steps.Length - 1)
        {
            currentStep++;
            ShowStep();
        }
    }

    public void PrevStep()
    {
        if (currentStep > 0)
        {
            currentStep--;
            ShowStep();
        }
    }

    private void ShowStep()
    {
        stepsText.text = steps[currentStep];

        if (modelController != null)
            modelController.ShowStepModel(currentStep);
    }
}