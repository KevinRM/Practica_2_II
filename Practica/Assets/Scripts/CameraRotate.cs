using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {
	public float XSensitivity = 2f;
	public float YSensitivity = 2f;
	public bool lockCursor = true;

	private Quaternion m_CharacterTargetRot;
	private Quaternion m_CameraTargetRot;
	private bool m_cursorIsLocked = true;

	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
		m_CharacterTargetRot = player.localRotation;
		m_CameraTargetRot = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		float yRot = Input.GetAxis ("Mouse X") * XSensitivity;
		float xRot = Input.GetAxis ("Mouse Y") * YSensitivity;

		m_CharacterTargetRot *= Quaternion.Euler (0f, yRot, 0f);
		m_CameraTargetRot *= Quaternion.Euler (-xRot, 0f, 0f);

		player.localRotation = m_CharacterTargetRot;
		transform.localRotation = m_CameraTargetRot;

		UpdateCursorLock();
	}

	public void UpdateCursorLock()
	{
		//if the user set "lockCursor" we check & properly lock the cursos
		if (lockCursor)
			InternalLockUpdate();
	}

	private void InternalLockUpdate()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			m_cursorIsLocked = false;
		}
		else if(Input.GetMouseButtonUp(0))
		{
			m_cursorIsLocked = true;
		}

		if (m_cursorIsLocked)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		else if (!m_cursorIsLocked)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
