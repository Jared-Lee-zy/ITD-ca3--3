using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public int triggerIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TutorialManager.Instance.TriggerCompleted(triggerIndex);
        }
    }
}