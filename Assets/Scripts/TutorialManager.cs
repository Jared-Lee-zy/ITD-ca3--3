using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public static TutorialManager Instance;

    public int currentTriggerIndex = 0;
    public int totalTriggers = 3;

    public GameObject teleportArea1;
    public GameObject teleportArea2;

    public GameObject congratsCanvas;

    private int currentTeleportIndex = 0;

    void Awake()
    {
        Instance = this;

        // Disable teleports at start
        teleportArea1.SetActive(false);
        teleportArea2.SetActive(false);
    }

    public void TriggerCompleted(int triggerIndex)
    {
        if (triggerIndex == currentTriggerIndex)
        {
            currentTriggerIndex++;

            Debug.Log("Trigger " + triggerIndex + " completed.");

            if (currentTriggerIndex >= totalTriggers)
            {
                EnableFirstTeleport();
            }
        }
    }

    void EnableFirstTeleport()
    {
        teleportArea1.SetActive(true);
        currentTeleportIndex = 1;
        Debug.Log("Teleport 1 Enabled");
    }

    public void TeleportCompleted(int teleportIndex)
    {
        if (teleportIndex == currentTeleportIndex)
        {
            if (teleportIndex == 1)
            {
                teleportArea2.SetActive(true);
                currentTeleportIndex = 2;
                Debug.Log("Teleport 2 Enabled");
            }
            else if (teleportIndex == 2)
            {
                Debug.Log("Tutorial Complete!");
                congratsCanvas.SetActive(true);
            }
        }
    }
}