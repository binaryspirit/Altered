    using UnityEngine;
     using System.Collections;
     using UnityEngine.UI;
      
     [ExecuteInEditMode]
     public class SharpText : MonoBehaviour
     {
         void Start ()
         {
             GetComponent<Text>().font.material.mainTexture.filterMode = FilterMode.Point;
         }
     }