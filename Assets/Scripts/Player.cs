using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	[SerializeField] private float f_JumpForce = 10f;

    [SerializeField] private Rigidbody2D m_Rigidbody2D;
    [SerializeField] private SpriteRenderer m_SpriteRenderer;

    [SerializeField] private string currentColor;

	[Header("==== Colours ====")]
    [SerializeField] private Color colorCyan;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorMagenta;
    [SerializeField] private Color colorPink;

	void Start ()
	{
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			m_Rigidbody2D.velocity = Vector2.up * f_JumpForce;
		}
		

    }

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag("ColorChanger"))
		{
			SetRandomColor();
			Destroy(other.gameObject);
			return;
		}

		if (other.tag != currentColor)
		{
			Time.timeScale = 0;
			Debug.Log("GAME OVER!");
			GameManager.instance.GameOver();
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
        if (other.CompareTag("Destroyer"))
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER!");
            GameManager.instance.GameOver();
        }

    }

	private void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				m_SpriteRenderer.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				m_SpriteRenderer.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				m_SpriteRenderer.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				m_SpriteRenderer.color = colorPink;
				break;
		}
	}

	
}
