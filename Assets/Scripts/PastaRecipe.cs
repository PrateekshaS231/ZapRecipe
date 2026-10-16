using UnityEngine;
using TMPro;

public class PastaRecipe : MonoBehaviour
{
    public TextMeshProUGUI stepsText;
    public StepModelController modelController;

    private string[] steps = {
        "Step 1: Boil water with a pinch of salt",
        "Step 2: Add DiSano pasta and cook for 10 minutes",
        "Step 3: Drain the water and set pasta aside",
        "Step 4: Add a cup of cream, sauce and herbs of choice into a sauce pan.",
        "Step 5: Add the cooked pasta into the sauce and stir well",
        "Step 6: Serve hot and enjoy!"
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