using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
   public void StageStart()
    {
        PhotonNetwork.LoadLevel("Town");
    }
}
