using UnityEngine;
using Unity.Netcode.Components;
[DisallowMultipleComponent]

public class ClientAuthNetworkTransform : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}


