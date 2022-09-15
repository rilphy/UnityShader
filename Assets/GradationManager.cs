using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradationManager : MonoBehaviour
{
	public List<MeshRenderer> listMeshRenderer = new List<MeshRenderer>();
	float val = 0.0f;
	float g_fCount = 0;

	const float MaxTimer = 1.0f;

	private void Awake()
	{
		
	}
	// Start is called before the first frame update
	void Start()
    {
		// ¸ÊÇÎ
		var obj = GameObject.FindGameObjectsWithTag("Shader");
		foreach(var go in obj) {
			listMeshRenderer.Add(go.GetComponent<MeshRenderer>());
		}
	}

    // Update is called once per frame
    void Update()
    {
		g_fCount += Time.deltaTime;

		if(g_fCount > MaxTimer)
		{
			g_fCount -= MaxTimer;

			val += 0.1f;

			foreach (var render in listMeshRenderer)
			{
				render.material.SetFloat("Value", val);
				render.material.SetFloat("_Value", val);
			}
		}
	}


}
