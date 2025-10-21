using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variabel publik untuk menampung objek pemain yang akan diikuti
    public GameObject player; 
    
    // Variabel untuk menyimpan perbedaan posisi antara kamera dan pemain (offset)
    private Vector3 offset = new Vector3(0, 5, -7); 
    // ^ (0: samping/horizontal, 5: tinggi, -15: jarak di belakang)

    // LateUpdate dipanggil setelah semua objek di Update() selesai bergerak
    void LateUpdate() 
    {
        // Tetapkan posisi kamera sama dengan posisi pemain DITAMBAH offset
        transform.position = player.transform.position + offset;
    }
}