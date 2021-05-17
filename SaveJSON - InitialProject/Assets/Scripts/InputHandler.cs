using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    [SerializeField] InputField nameInput;

    List<InputEntry> entries = new List<InputEntry> ();

    public void AddNameToList () {
        entries.Add (new InputEntry (nameInput.text, Random.Range (0, 100)));
        nameInput.text = "";
    }

}