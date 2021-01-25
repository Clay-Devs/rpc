using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordPresence;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public Text detail_txt;
    public Text state_txt;

    public InputField clientID;
    public InputField detail;
    public InputField state;

    public void SaveSettings()
    {
        PresenceManager.instance.applicationId = clientID.text;
        DiscordRpc.Initialize(PresenceManager.instance.applicationId, ref PresenceManager.instance.handlers, true, PresenceManager.instance.optionalSteamId);

        DiscordPresence.PresenceManager.UpdatePresence(detail: detail.text, state: state.text);

        detail_txt.text = detail.text;
        state_txt.text = state.text;
    }
}
