using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _powerSpeed = 3.0f;
    [SerializeField]
    private int _powerupID; // 0 = TripleShot, 1 = Speed, 2 = Shield
    [SerializeField]
    private AudioClip _audioClip;

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _powerSpeed * Time.deltaTime);
        
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                AudioSource.PlayClipAtPoint(_audioClip, transform.position);

                switch (_powerupID)
                {
                    case 0:
                        player.TripleShotActive();
                        break;
                    case 1:
                        Debug.Log("Collected Speed Booster");
                        player.SpeedPowerActive();
                        break;
                    case 2:
                        Debug.Log("Collected Shield");
                        player.shieldPowerupActive();
                        break;
                    default:
                        Debug.Log("Default Value");
                        break;
                }
                Destroy(this.gameObject);
            }
            
        }
    }
}
