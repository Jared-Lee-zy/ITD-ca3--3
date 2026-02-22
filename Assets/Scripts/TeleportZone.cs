using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit.Locomotion;

public class TeleportZone : MonoBehaviour
{
    public int teleportIndex;

    private UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea teleportArea;

    void Start()
    {
        teleportArea = GetComponent<UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea>();

        if (teleportArea != null)
        {
            teleportArea.teleporting.AddListener(OnTeleportUsed);
        }
        else
        {
            Debug.LogError("TeleportationArea component missing!");
        }
    }

    void OnTeleportUsed(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportingEventArgs args)
    {
        TutorialManager.Instance.TeleportCompleted(teleportIndex);
    }
}