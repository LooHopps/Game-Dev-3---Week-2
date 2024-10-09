using GameDevWithMarco.Guns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class Guns_Sniper : Guns_Parent
    {
        public override void GunSound()
        {
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            gunAudioSource.PlayOneShot(gunSound);
        }
    }
}
