using UnityEngine;

public class tpScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ÚG‚µ‚Ä“¾‚ç‚ê‚½•Ï” collision “à‚Ì gameObject ‚Ì name ‚ªuPlayerv‚È‚ç
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<MoveCharacter>().tpHit();
        }
    }
}
