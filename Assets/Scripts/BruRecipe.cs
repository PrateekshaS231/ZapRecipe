using UnityEngine;
using TMPro;

public class BruRecipe : MonoBehaviour
{
    public TextMeshProUGUI stepsText;
    public StepModelController modelController;

    private string[] steps = {
        "Step 1: In a cup, mix 1.5 teaspoons of instant coffee and 1.5 tablespoons of sugar.",
        "Step 2: Add 3 tablespoons of hot (boiling) water",
        "Step 3: Stir briskly or whisk for 3 to 4 minutes until the mixture lightens in color and forms a thick, creamy foam.",
        "Step 4: Pour hot, frothed milk over the top and stir gently.",
        "Step 5: Pour into a cup and enjoy!"
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