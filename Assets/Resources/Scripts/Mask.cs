using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Resources.Scripts
{
    public enum MaskColour
    {
        None, Red, Green, Blue, Yellow
    }

    public class Mask : MonoBehaviour, IInteractable
    {
        [SerializeField]
        public MaskColour maskColour;
        [SerializeField]
        public GameObject parentThing;

        public void ToggleMask()
        {
            parentThing.SetActive(!parentThing.activeSelf);
        }
    }
}
