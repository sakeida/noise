	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[RequireComponent(typeof(LootCrate))]
	public class LootCrateKeyController : MonoBehaviour {
		private LootCrate _lootCrate;
	public GameObject noise;
	bool flag=false;
		/*public KeyCode openKey = KeyCode.Space;
		public KeyCode closeKey = KeyCode.Space;

		private LootCrate _lootCrate;
	*/
		private void Awake()
		{
			_lootCrate = GetComponent<LootCrate>();
		}
	private void Update()
		{
			if (_lootCrate.IsOpeningOrClosing()) return;
		}
			/*
			if (Input.GetKeyDown(openKey) && _lootCrate.IsClosed()) _lootCrate.Open();
			if (Input.GetKeyDown(closeKey) && _lootCrate.IsOpen()) _lootCrate.Close();
		}*/
		void OnTriggerEnter ( Collider obj  ){
		if (obj.gameObject.tag == "player"&&flag==false) {
			_lootCrate.Open ();
			noise.gameObject.SetActive (true);
			flag = true;
		}
	}

	}
