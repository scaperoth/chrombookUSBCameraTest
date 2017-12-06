using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour {

	private Text _textBox;

	private string _defaultText = "Available Devices: ";

	// Use this for initialization
	void Start () {
		_textBox = FindObjectOfType<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		_textBox.text = _defaultText+"\n";
		for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++) {
			
			_textBox.text += WebCamTexture.devices[cameraIndex].name + "\n";
		}
	}
}
